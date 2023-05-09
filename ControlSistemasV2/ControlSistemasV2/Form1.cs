using Common;
using Data;
using Entity;
using Logic;
using System.Runtime.CompilerServices;

namespace ControlSistemasV2
{
    public partial class FrmControl : MetroFramework.Forms.MetroForm
    {
        public readonly BGeneral bGeneral;
        public List<Sistema> sistemas = new List<Sistema>();
        public List<Equipo> equipos = new List<Equipo>();

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
            sistemas = await taskVersiones;

            spiner1.Visible = false;
            grdPublicaciones.DataSource = sistemas;
            spiner2.Visible = false;
            grdLista.DataSource = equipos;

        }


        void limpiarGrds()
        {
            grdLista.DataSource = new List<Equipo>();
            grdPublicaciones.DataSource = new List<Sistema>();
        }


    }
}
