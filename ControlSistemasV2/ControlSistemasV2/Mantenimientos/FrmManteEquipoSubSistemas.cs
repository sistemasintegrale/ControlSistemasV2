using Entity;
using Entity.DTOs;
using Logic;
using System.Data;

namespace ControlSistemasV2.Mantenimientos
{
    public partial class FrmManteEquipoSubSistemas : MetroFramework.Forms.MetroForm
    {
        public int IdEquipo;
        public readonly BGeneral bGeneral;
        List<EquiposSubSistema> lista = new List<EquiposSubSistema>();
        List<EquipoSubSistemaDTO> listadto = new List<EquipoSubSistemaDTO>();
        public FrmManteEquipoSubSistemas()
        {
            this.bGeneral = new BGeneral();
            InitializeComponent();
        }

        private void FrmManteEquipoSubSistemas_Load(object sender, EventArgs e)
        {
            lista = bGeneral.EquipoSubSistemaListar().Where(x => x.IdEquipo == IdEquipo).ToList();
            listadto = new List<EquipoSubSistemaDTO>();
            lista.ForEach(x =>
            {
                x.Sistema = bGeneral.SistemaListar().Where(y=>y.Id == x.IdSistema).FirstOrDefault()!;
                listadto.Add(new EquipoSubSistemaDTO()
                {
                    IdSistema = x.IdSistema,
                    Acceso = x.Acceso,
                    FechaActualizacion= x.FechaActualizacion,
                    nombreSistema = x.Sistema.Nombre
                });
            });
            grdLista.DataSource = listadto;
            grdLista.Refresh();
        }

        private void darAccesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdLista.SelectedCells.Count == 0)
                return;

            int index = grdLista.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdLista.Rows[index];
            var select = lista.Where(x=>x.IdSistema == Convert.ToInt32(selectedRow.Cells["IdSistema"].Value)).FirstOrDefault()!;
            select.Acceso = !select.Acceso;
            bGeneral.EquipoSubSistemaModificarDarAcceso(select);
            FrmManteEquipoSubSistemas_Load(sender, e);
        }
    }
}
