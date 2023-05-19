using Entity;
using Logic;
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
    public partial class FrmManteEquipos : MetroFramework.Forms.MetroForm
    {
        public Equipo equipo = new Equipo();
        private readonly BGeneral bGeneral;
        public FrmManteEquipos()
        {
            InitializeComponent();
            bGeneral = new BGeneral();
        }

        private void FrmManteEquipos_Load(object sender, EventArgs e)
        {
            txtNombre.Text = equipo.Nombre;
            txtCpu.Text = equipo.Cpu;
            txtActualizador.Text = equipo.UbicacionActualizador;
            txtUsuario.Text = equipo.NombreUsuario;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            equipo.NombreUsuario= txtUsuario.Text;
            bGeneral.EquipoModificar(equipo);
            this.DialogResult= DialogResult.OK;
        }
    }
}
