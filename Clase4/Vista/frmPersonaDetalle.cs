﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase4.Vista
{
    public partial class frmPersonaDetalle : Form
    {
        public frmPersonaDetalle()
        {
            InitializeComponent();
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPruebaDB);

        }

        private void frmPersonaDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPruebaDB.Persona' Puede moverla o quitarla según sea necesario.
            this.personaTableAdapter.Fill(this.dsPruebaDB.Persona);

        }
    }
}
