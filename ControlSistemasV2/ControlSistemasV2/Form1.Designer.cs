namespace ControlSistemasV2
{
    partial class FrmControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            btnJaguar = new Guna.UI2.WinForms.Guna2Button();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            spiner2 = new MetroFramework.Controls.MetroProgressSpinner();
            grdEquipos = new Guna.UI2.WinForms.Guna2DataGridView();
            mmenuEquipos = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem2 = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            spiner1 = new MetroFramework.Controls.MetroProgressSpinner();
            grdSistemas = new Guna.UI2.WinForms.Guna2DataGridView();
            mmenuSistemas = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            nuevoToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            versionesToolStripMenuItem = new ToolStripMenuItem();
            btnJabsa = new Guna.UI2.WinForms.Guna2Button();
            guna2GroupBox1.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdEquipos).BeginInit();
            mmenuEquipos.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSistemas).BeginInit();
            mmenuSistemas.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(btnJabsa);
            guna2GroupBox1.Controls.Add(btnJaguar);
            guna2GroupBox1.CustomizableEdges = customizableEdges5;
            guna2GroupBox1.Dock = DockStyle.Left;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(20, 60);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GroupBox1.Size = new Size(209, 370);
            guna2GroupBox1.TabIndex = 0;
            guna2GroupBox1.Text = "Empresas";
            // 
            // btnJaguar
            // 
            btnJaguar.Animated = true;
            btnJaguar.AnimatedGIF = true;
            btnJaguar.CustomizableEdges = customizableEdges3;
            btnJaguar.DisabledState.BorderColor = Color.DarkGray;
            btnJaguar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnJaguar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnJaguar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnJaguar.Dock = DockStyle.Top;
            btnJaguar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnJaguar.ForeColor = Color.White;
            btnJaguar.Location = new Point(0, 40);
            btnJaguar.Name = "btnJaguar";
            btnJaguar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnJaguar.Size = new Size(209, 45);
            btnJaguar.TabIndex = 0;
            btnJaguar.Text = "Calzados Jaguar ";
            btnJaguar.Click += btnEmpresas_Click;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(tabPage1);
            guna2TabControl1.Controls.Add(tabPage2);
            guna2TabControl1.Dock = DockStyle.Fill;
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(229, 60);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(689, 370);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 1;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(spiner2);
            tabPage1.Controls.Add(grdEquipos);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(681, 322);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Equipos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // spiner2
            // 
            spiner2.Location = new Point(290, 111);
            spiner2.Maximum = 100;
            spiner2.Name = "spiner2";
            spiner2.Size = new Size(100, 100);
            spiner2.Style = MetroFramework.MetroColorStyle.Green;
            spiner2.TabIndex = 2;
            spiner2.Text = "metroProgressSpinner1";
            spiner2.Theme = MetroFramework.MetroThemeStyle.Light;
            spiner2.UseSelectable = true;
            spiner2.Value = 10;
            // 
            // grdEquipos
            // 
            grdEquipos.AllowUserToAddRows = false;
            grdEquipos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            grdEquipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdEquipos.ColumnHeadersHeight = 17;
            grdEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grdEquipos.ContextMenuStrip = mmenuEquipos;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdEquipos.DefaultCellStyle = dataGridViewCellStyle3;
            grdEquipos.Dock = DockStyle.Fill;
            grdEquipos.GridColor = Color.FromArgb(231, 229, 255);
            grdEquipos.Location = new Point(3, 3);
            grdEquipos.Name = "grdEquipos";
            grdEquipos.ReadOnly = true;
            grdEquipos.RowHeadersVisible = false;
            grdEquipos.RowTemplate.Height = 25;
            grdEquipos.Size = new Size(675, 316);
            grdEquipos.TabIndex = 0;
            grdEquipos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            grdEquipos.ThemeStyle.AlternatingRowsStyle.Font = null;
            grdEquipos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            grdEquipos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            grdEquipos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            grdEquipos.ThemeStyle.BackColor = Color.White;
            grdEquipos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            grdEquipos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            grdEquipos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            grdEquipos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grdEquipos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            grdEquipos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grdEquipos.ThemeStyle.HeaderStyle.Height = 17;
            grdEquipos.ThemeStyle.ReadOnly = true;
            grdEquipos.ThemeStyle.RowsStyle.BackColor = Color.White;
            grdEquipos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdEquipos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grdEquipos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            grdEquipos.ThemeStyle.RowsStyle.Height = 25;
            grdEquipos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            grdEquipos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // mmenuEquipos
            // 
            mmenuEquipos.Items.AddRange(new ToolStripItem[] { modificarToolStripMenuItem, modificarToolStripMenuItem2 });
            mmenuEquipos.Name = "mmenuEquipos";
            mmenuEquipos.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            mmenuEquipos.RenderStyle.BorderColor = Color.Gainsboro;
            mmenuEquipos.RenderStyle.ColorTable = null;
            mmenuEquipos.RenderStyle.RoundedEdges = true;
            mmenuEquipos.RenderStyle.SelectionArrowColor = Color.White;
            mmenuEquipos.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            mmenuEquipos.RenderStyle.SelectionForeColor = Color.White;
            mmenuEquipos.RenderStyle.SeparatorColor = Color.Gainsboro;
            mmenuEquipos.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            mmenuEquipos.Size = new Size(137, 48);
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(136, 22);
            modificarToolStripMenuItem.Text = "Ver Accesos";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem2
            // 
            modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            modificarToolStripMenuItem2.Size = new Size(136, 22);
            modificarToolStripMenuItem2.Text = "Modificar";
            modificarToolStripMenuItem2.Click += modificarToolStripMenuItem2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(spiner1);
            tabPage2.Controls.Add(grdSistemas);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(681, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sistemas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // spiner1
            // 
            spiner1.Location = new Point(290, 111);
            spiner1.Maximum = 100;
            spiner1.Name = "spiner1";
            spiner1.Size = new Size(100, 100);
            spiner1.Style = MetroFramework.MetroColorStyle.Green;
            spiner1.TabIndex = 2;
            spiner1.Text = "metroProgressSpinner1";
            spiner1.Theme = MetroFramework.MetroThemeStyle.Light;
            spiner1.UseSelectable = true;
            spiner1.Value = 10;
            // 
            // grdSistemas
            // 
            grdSistemas.AllowUserToAddRows = false;
            grdSistemas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            grdSistemas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            grdSistemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            grdSistemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            grdSistemas.ColumnHeadersHeight = 17;
            grdSistemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grdSistemas.ContextMenuStrip = mmenuSistemas;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            grdSistemas.DefaultCellStyle = dataGridViewCellStyle6;
            grdSistemas.Dock = DockStyle.Fill;
            grdSistemas.GridColor = Color.FromArgb(231, 229, 255);
            grdSistemas.Location = new Point(3, 3);
            grdSistemas.MultiSelect = false;
            grdSistemas.Name = "grdSistemas";
            grdSistemas.ReadOnly = true;
            grdSistemas.RowHeadersVisible = false;
            grdSistemas.RowTemplate.Height = 25;
            grdSistemas.RowTemplate.ReadOnly = true;
            grdSistemas.Size = new Size(675, 316);
            grdSistemas.TabIndex = 0;
            grdSistemas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            grdSistemas.ThemeStyle.AlternatingRowsStyle.Font = null;
            grdSistemas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            grdSistemas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            grdSistemas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            grdSistemas.ThemeStyle.BackColor = Color.White;
            grdSistemas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            grdSistemas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            grdSistemas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            grdSistemas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grdSistemas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            grdSistemas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grdSistemas.ThemeStyle.HeaderStyle.Height = 17;
            grdSistemas.ThemeStyle.ReadOnly = true;
            grdSistemas.ThemeStyle.RowsStyle.BackColor = Color.White;
            grdSistemas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSistemas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grdSistemas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            grdSistemas.ThemeStyle.RowsStyle.Height = 25;
            grdSistemas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            grdSistemas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // mmenuSistemas
            // 
            mmenuSistemas.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem1, modificarToolStripMenuItem1, versionesToolStripMenuItem });
            mmenuSistemas.Name = "mmenuSistemas";
            mmenuSistemas.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            mmenuSistemas.RenderStyle.BorderColor = Color.Gainsboro;
            mmenuSistemas.RenderStyle.ColorTable = null;
            mmenuSistemas.RenderStyle.RoundedEdges = true;
            mmenuSistemas.RenderStyle.SelectionArrowColor = Color.White;
            mmenuSistemas.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            mmenuSistemas.RenderStyle.SelectionForeColor = Color.White;
            mmenuSistemas.RenderStyle.SeparatorColor = Color.Gainsboro;
            mmenuSistemas.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            mmenuSistemas.Size = new Size(126, 70);
            // 
            // nuevoToolStripMenuItem1
            // 
            nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            nuevoToolStripMenuItem1.Size = new Size(125, 22);
            nuevoToolStripMenuItem1.Text = "Nuevo";
            nuevoToolStripMenuItem1.Click += nuevoToolStripMenuItem1_Click;
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(125, 22);
            modificarToolStripMenuItem1.Text = "Modificar";
            modificarToolStripMenuItem1.Click += modificarToolStripMenuItem1_Click;
            // 
            // versionesToolStripMenuItem
            // 
            versionesToolStripMenuItem.Name = "versionesToolStripMenuItem";
            versionesToolStripMenuItem.Size = new Size(125, 22);
            versionesToolStripMenuItem.Text = "Versiones";
            versionesToolStripMenuItem.Click += versionesToolStripMenuItem_Click;
            // 
            // btnJabsa
            // 
            btnJabsa.Animated = true;
            btnJabsa.AnimatedGIF = true;
            btnJabsa.CustomizableEdges = customizableEdges1;
            btnJabsa.DisabledState.BorderColor = Color.DarkGray;
            btnJabsa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnJabsa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnJabsa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnJabsa.Dock = DockStyle.Top;
            btnJabsa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnJabsa.ForeColor = Color.White;
            btnJabsa.Location = new Point(0, 85);
            btnJabsa.Name = "btnJabsa";
            btnJabsa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnJabsa.Size = new Size(209, 45);
            btnJabsa.TabIndex = 1;
            btnJabsa.Text = "Jabsa";
            btnJabsa.Click += btnJabsa_Click;
            // 
            // FrmControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 450);
            Controls.Add(guna2TabControl1);
            Controls.Add(guna2GroupBox1);
            Name = "FrmControl";
            Resizable = false;
            Text = "Form1";
            TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            Load += FrmControl_Load;
            guna2GroupBox1.ResumeLayout(false);
            guna2TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdEquipos).EndInit();
            mmenuEquipos.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSistemas).EndInit();
            mmenuSistemas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnJaguar;
        private Guna.UI2.WinForms.Guna2DataGridView grdEquipos;
        private Guna.UI2.WinForms.Guna2DataGridView grdSistemas;
        private MetroFramework.Controls.MetroProgressSpinner spiner2;
        private MetroFramework.Controls.MetroProgressSpinner spiner1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip mmenuEquipos;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip mmenuSistemas;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem versionesToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem2;
        private Guna.UI2.WinForms.Guna2Button btnJabsa;
    }
}