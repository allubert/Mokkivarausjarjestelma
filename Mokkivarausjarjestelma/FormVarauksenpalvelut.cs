﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivarausjarjestelma
{
    public partial class FormVarauksenpalvelut : Form
    {
        public FormVarauksenpalvelut()
        {
            InitializeComponent();

            Comboboxfill();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");
        MySqlCommand command;

        public void populatedgvVarauspalvelut()
        {
            //hae dataa
            string selectQuery = "SELECT * FROM varauksen_palvelut";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvVarauksenpalvelut.DataSource = table;
        }

        public void Comboboxfill() //funktio jossa määritetään comboboxien täyttäminen
        {
            using (connection)
            {
                try
                {
                    //täyttää varausID comboboxin! huomioi että varausid pitää luoda, jotta se löytää kyseisen varauksen
                    string varausidQuery = "SELECT varaus_id FROM varaus";
                    MySqlDataAdapter alueAdapter = new MySqlDataAdapter(varausidQuery, connection);
                    DataSet varausDs = new DataSet();
                    alueAdapter.Fill(varausDs, "varaus");

                    cmbVarausID.DisplayMember = "varaus_id";
                    cmbVarausID.ValueMember = "varaus_id";
                    cmbVarausID.DataSource = varausDs.Tables["varaus"];


                    //täyttää palveluID comboboxin! huomioi että palveluid pitää luoda, jotta se löytää kyseisen varauksen
                    string palveluidQuery = "SELECT palvelu_id FROM palvelu";
                    MySqlDataAdapter palveluAdapter = new MySqlDataAdapter(palveluidQuery, connection);
                    DataSet palveluDs = new DataSet();
                    palveluAdapter.Fill(palveluDs, "palvelu");

                    cmbPalveluID.DisplayMember = "palvelu_id";
                    cmbPalveluID.ValueMember = "palvelu_id";
                    cmbPalveluID.DataSource = palveluDs.Tables["palvelu"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnVaraukseen_Click(object sender, EventArgs e)
        {
            Form varaus = new FormMokitJaMokkivaraukset();
            this.Hide();

            varaus.ShowDialog();
            this.Close();
        }

        private void btnPalveluihin_Click(object sender, EventArgs e)
        {
            Form palvelut = new FormPalveluhallinta();
            this.Hide();

            palvelut.ShowDialog();
            this.Close();
        }

        private void btnLaskuihin_Click(object sender, EventArgs e)
        {
            Form laskut = new FormLaskutus();
            this.Hide();

            laskut.ShowDialog();
            this.Close();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //tarkistaa onko combobokseissa tietoa
            if (cmbPalveluID.SelectedValue == null || cmbVarausID.SelectedValue == null)
            {
                MessageBox.Show("Valitse arvo molemmille combobokseille!");
                return;
            }
            string palveluid = cmbPalveluID.SelectedValue.ToString();
            string varausid = cmbVarausID.SelectedValue.ToString();
            int lkm = int.Parse(tbLkm.Text);

            string insertQuery = "INSERT INTO varauksen_palvelut (varaus_id, palvelu_id, lkm) VALUES (@varausid, @palveluid, @lkm)";
            string selectQuery = "SELECT * FROM varauksen_palvelut WHERE varaus_id = @varausid AND palvelu_id = @palveluid";

            using (connection)
            {
                try
                {
                    connection.Open();
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@varausid", varausid);
                    insertCommand.Parameters.AddWithValue("@palveluid", palveluid);
                    insertCommand.Parameters.AddWithValue("@lkm", lkm);
                    insertCommand.ExecuteNonQuery();

                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@varausid", varausid);
                    selectCommand.Parameters.AddWithValue("@palveluid", palveluid);

                    DataTable datatable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand))
                    {
                        adapter.Fill(datatable);
                        populatedgvVarauspalvelut();
                    }
                    dgvVarauksenpalvelut.DataSource = datatable;
                    populatedgvVarauspalvelut();

                    connection.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void tbLkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Syötä haluamasi lukumäärä numeromuodossa!");
                e.Handled = true;
            }
        }

        private void FormVarauksenpalvelut_Load(object sender, EventArgs e)
        {
            populatedgvVarauspalvelut();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {

        }
    }
}
