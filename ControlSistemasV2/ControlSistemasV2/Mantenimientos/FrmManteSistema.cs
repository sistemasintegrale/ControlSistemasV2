﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSistemasV2.Mantenimientos
{
    public partial class FrmManteSistema : MetroFramework.Forms.MetroForm
    {
        public FrmManteSistema()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
