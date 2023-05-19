using Entity;
using Entity.DTOs;
using Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace ControlSistemasV2.Mantenimientos
{
    public partial class FrmVersiones : MetroFramework.Forms.MetroForm
    {
        public Sistema sistema = new Sistema();
        public readonly BGeneral bGeneral;
        public List<SubSistemaDTO> subSistemasDTO = new List<SubSistemaDTO>();
        public FrmVersiones()
        {
            InitializeComponent(); 
            bGeneral = new BGeneral();
        }

        private void FrmVersiones_Load(object sender, EventArgs e)
        {
            cargar();
        }
        async void cargar()
        {
            Task<List<SubSistema>> SubSistemas = new Task<List<SubSistema>>(bGeneral.SubSistemaListar);
            SubSistemas.Start();
            var lista = await SubSistemas;
            lista.Where(x => x.IdSistema == sistema.Id).ToList().ForEach(x =>
            {
                subSistemasDTO.Add(new SubSistemaDTO()
                {
                    Comentarios = x.Comentarios,
                    Disponible = x.Disponible,
                    Fecha = x.Fecha,
                    Id = x.Id,
                    IdSistema = x.IdSistema,
                    Link = x.Link,
                    Nombre = x.Nombre
                });
            });

            grdVersiones.DataSource = subSistemasDTO;
            grdVersiones.Refresh();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManteSubSistema frm = new FrmManteSubSistema();
            frm.Text = "Nueva Publicación";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SubSistema subSistema = new SubSistema();
                subSistema.IdSistema = sistema.Id;
                subSistema.Comentarios = frm.txtComentarios.Text;
                subSistema.Nombre = frm.txtNombre.Text;
                subSistema.Disponible = frm.checkDisponible.Checked;
                subSistema.Fecha = DateTime.Now;
                subSistema.Link = frm.txtLink.Text;
                subSistema.Id = bGeneral.SubSistemaIngresar(subSistema);
                cargar();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdVersiones.SelectedCells.Count == 0)
                return;

            int index = grdVersiones.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grdVersiones.Rows[index];

            var data = bGeneral.SubSistemaListar().Where(x => x.Id == Convert.ToInt32(selectedRow.Cells["Id"].Value)).FirstOrDefault()!;

            var nium = selectedRow.Cells;
            FrmManteSubSistema frm = new FrmManteSubSistema();
            frm.subSistema = data;
            frm.SetValues();
            frm.Text = $"Modificando - {data.Nombre}";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                data.IdSistema = sistema.Id;
                data.Comentarios = frm.txtComentarios.Text;
                data.Nombre = frm.txtNombre.Text;
                data.Disponible = frm.checkDisponible.Checked;
                data.Link = frm.txtLink.Text;
                bGeneral.SubSistemaModificar(data);
                cargar();
            }
        }
    }
}
