﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class FormToiminta : Form
    {
        public FormToiminta()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");
        MySqlCommand command;
        public void populatedgvToiminta()
        {
            //hae dataa
            string selectQuery = "SELECT * FROM alue";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvToiminta.DataSource = table;
        }
        public void ExecuteMyQuery(string query)
        {
            try
            {
                connection.Open();

                command = new MySqlCommand(query, connection);

                //if (command.ExecuteNonQuery() == 1)
                //{
                //    MessageBox.Show("Kysely suoritettu");
                //}
                //else
                //{
                //    MessageBox.Show("Kyselyä ei suoritettu");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnTakaisinAloitusFormiin_Click(object sender, EventArgs e)
        {
            Form formaloitus = new Form1();
            this.Hide();

            formaloitus.ShowDialog();
            this.Close();
        }

        private void btnToimintaLisaaAlue_Click(object sender, EventArgs e)
        {
           
            if (tbToimintaAlue.Text == "")
            {
                MessageBox.Show("Anna alueelle nimi.");
                return;
            }

            string nimi = tbToimintaAlue.Text;
            //int alueid = int.Parse(tbToimintaAlueid.Text);  
            //string postinro = tbToimintaPostinro.Text;
            //string toimipaikka = tbToimintaToimip.Text;


            string insertQuery = "INSERT INTO alue(nimi) VALUES (@nimi)";

            try
            {
                using (connection)
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nimi", nimi);
                        //command.Parameters.AddWithValue("@alueid", alueid);   
                        //command.Parameters.AddWithValue("@postinro", postinro);
                        //command.Parameters.AddWithValue("@toimipaikka", toimipaikka);

                        connection.Open();
                        command.ExecuteNonQuery();
                        populatedgvToiminta();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe");
            }
        }

      

        private void FormToiminta_Load(object sender, EventArgs e)
        {
            populatedgvToiminta();
        }

        private void dgvToiminta_MouseClick(object sender, MouseEventArgs e)
        {
            //tbToimintaAlue.Text = dgvToiminta.CurrentRow.Cells[0].Value.ToString();
            //tbToimintaAlueid.Text = dgvToiminta.CurrentRow.Cells[1].Value.ToString();
            //tbToimintaPostinro.Text = dgvToiminta.CurrentRow.Cells[2].Value.ToString();
            //tbToimintaPostinro.Text = dgvToiminta.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnToimintaPoistaAlue_Click(object sender, EventArgs e)
        {

            string deleteQuery = "DELETE FROM alue WHERE alue_id = @alue_id";

            if (dgvToiminta.SelectedRows.Count > 0)
            {
                int valittuIndex = dgvToiminta.SelectedRows[0].Index;
                int poistoID = Convert.ToInt32(dgvToiminta[0, valittuIndex].Value);

                DialogResult result = MessageBox.Show("Oletko varma, että haluat poistaa kyseisen rivin tietokannastasi? Tämä poistaa kaikki syöttämäsi tiedot tietokantaan.", "Vahvista valintasi!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (connection)
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@alue_id", poistoID);
                            command.ExecuteNonQuery();
                        }
                    }
                    dgvToiminta.Rows.RemoveAt(valittuIndex);
                    populatedgvToiminta();
                }


            }

        }

        private void btnToimintaKohteet_Click(object sender, EventArgs e)
        {
            Form formaloitus = new FormMokitJaMokkivaraukset();
            this.Hide();

            formaloitus.ShowDialog();
            this.Close();
        }
    }
}


    
    
    

