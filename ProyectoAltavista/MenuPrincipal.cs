﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void btCliente_Click_1(object sender, EventArgs e)
        {
            MantenedorCliente mantenedorCli = new MantenedorCliente();
            this.Hide();
            mantenedorCli.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
