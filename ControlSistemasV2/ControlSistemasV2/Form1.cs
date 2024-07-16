using Common;
using ControlSistemasV2.Mantenimientos;
using Data;
using Entity;
using Entity.DTOs;
using Logic;
using System.Runtime.CompilerServices;

namespace ControlSistemasV2
{
    public partial class FrmControl : MetroFramework.Forms.MetroForm
    {
        public readonly BGeneral bGeneral;
        public List<Sistema> sistemas = new List<Sistema>();
        public List<Equipo> equipos = new List<Equipo>();
        public List<SistemaDTO> sistemasDto = new List<SistemaDTO>();
        public List<EquipoDTO> equiposDto = new List<EquipoDTO>();

        public FrmControl()
        {
            this.bGeneral = new BGeneral();
            InitializeComponent();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            limpiarGrds();
            Constantes.Connection = Constantes.ConnCalzadosJaguar;
            this.Text = btnJaguar.Text;
            this.Refresh();
            cargar();
        }

        public async void cargar()
        {
            spiner1.Visible = true;
            spiner2.Visible = true;
            Task<List<Equipo>> taskEquipos = new Task<List<Equipo>>(bGeneral.EquipoListar);
            Task<List<Sistema>> taskVersiones = new Task<List<Sistema>>(bGeneral.SistemaListar);
            taskVersiones.Start();
            taskEquipos.Start();
            equipos = await taskEquipos;
            equipos.ForEach(x =>
            {
                equiposDto.Add(new EquipoDTO()
                {
                    Cpu = x.Cpu,
                    Id = x.Id,
                    Nombre = x.Nombre,
                    NombreUsuario = x.NombreUsuario,
                    UbicacionActualizador = x.UbicacionActualizador
                });
            });
            sistemas = await taskVersiones;
            sistemas.ForEach(x =>
            {
                sistemasDto.Add(new SistemaDTO()
                {
                    Id = x.Id,
                    Nombre = x.Nombre
                });
            });
            spiner1.Visible = false;
            grdSistemas.DataSource = sistemasDto;
            spiner2.Visible = false;
            grdEquipos.DataSource = equiposDto;

        }


        void limpiarGrds()
        {
            sistemasDto = new List<SistemaDTO>();
            equiposDto = new List<EquipoDTO>();
            grdEquipos.DataSource = new List<EquipoDTO>();
            grdSistemas.DataSource = new List<SistemaDTO>();
        }

        private async void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmManteSistema frm = new FrmManteSistema();
            frm.Text = "Nuevo Registro";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Sistema nuevo = new Sistema();
                nuevo.Nombre = frm.txtNombre.Text;
                Task guardarSistema = new Task(() => bGeneral.SistemaIngresar(nuevo));
                guardarSistema.Start();
                await guardarSistema;
                limpiarGrds();
                cargar();
            }
        }

        private void versionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdSistemas.SelectedCells.Count == 0)
                return;

            int index = grdSistemas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdSistemas.Rows[index];

            var data = bGeneral.SistemaListar().Where(x => x.Id == Convert.ToInt32(selectedRow.Cells["Id"].Value)).FirstOrDefault()!;

            FrmVersiones frm = new FrmVersiones();
            frm.Text = data.Nombre.ToString();
            frm.sistema = data;
            frm.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (grdSistemas.SelectedCells.Count == 0)
                return;

            int index = grdSistemas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdSistemas.Rows[index];

            var data = bGeneral.SistemaListar().Where(x => x.Id == Convert.ToInt32(selectedRow.Cells["Id"].Value)).FirstOrDefault()!;
            FrmManteSistema frm = new FrmManteSistema();
            frm.txtNombre.Text = data.Nombre.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                data.Nombre = frm.txtNombre.Text;
                bGeneral.SistemaModificar(data);
                limpiarGrds();
                cargar();
            }
        }

        private void FrmControl_Load(object sender, EventArgs e)
        {
            btnEmpresas_Click(sender, e);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdEquipos.SelectedCells.Count == 0)
                return;

            int index = grdEquipos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdEquipos.Rows[index];
            FrmManteEquipoSubSistemas frm = new FrmManteEquipoSubSistemas();
            frm.IdEquipo = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            frm.Text = $"Accesos del Equipo {selectedRow.Cells["Nombre"].Value}";
            frm.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (grdEquipos.SelectedCells.Count == 0)
                return;

            int index = grdEquipos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdEquipos.Rows[index];
            FrmManteEquipos frm = new FrmManteEquipos();
            frm.equipo = equipos.Where(x => x.Id == Convert.ToInt32(selectedRow.Cells["Id"].Value)).FirstOrDefault()!;
            frm.Text = $"Mantenimiento {frm.equipo.Nombre}";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                limpiarGrds();
                cargar();
            }
        }

        private void btnJabsa_Click(object sender, EventArgs e)
        {
            limpiarGrds();
            Constantes.Connection = Constantes.ConnJabsa;
            this.Text = btnJabsa.Text;
            this.Refresh();
            cargar();
        }
    }
}
