﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsaTanger
{
    public partial class GestionEleves : Form
    {
        public GestionEleves(MDI mdi)
        {
            InitializeComponent();
            MdiParent = mdi;
            TopLevel = false;
            Dock = DockStyle.Fill;
        }

        private void buttonGestionNotes_Click(object sender, EventArgs e)
        {
            GestionNotes newMDIChild = new GestionNotes();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this.MdiParent;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
