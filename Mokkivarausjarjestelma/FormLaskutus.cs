﻿using System;
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
    public partial class FormLaskutus : Form
    {
        public FormLaskutus()
        {
            InitializeComponent();
        }

        private void btnTakaisinAloitusFormiin_Click(object sender, EventArgs e)
        {
            Form formaloitus = new Form1();
            this.Hide();

            formaloitus.ShowDialog();
            this.Close();
        }
    }
}
