using Entity;
using System;
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
    public partial class FrmManteSubSistema : MetroFramework.Forms.MetroForm
    {
        public SubSistema subSistema = new SubSistema();

        public FrmManteSubSistema()
        {
            InitializeComponent();
        }

        internal void SetValues()
        {
            txtComentarios.Text = subSistema.Comentarios;
            txtNombre.Text = subSistema.Nombre;
            checkDisponible.Checked= subSistema.Disponible;
            txtLink.Text = subSistema.Link;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK; 
        }
    }
}
