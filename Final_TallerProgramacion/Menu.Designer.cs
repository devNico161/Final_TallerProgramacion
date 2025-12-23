namespace Final_TallerProgramacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvLibros = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            librosToolStripMenuItem = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            estudiantesToolStripMenuItem = new ToolStripMenuItem();
            prestamosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            dgv_Libros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Libros).BeginInit();
            SuspendLayout();
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.Location = new Point(0, 24);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(550, 301);
            dgvLibros.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(dgv_Libros);
            panel1.Location = new Point(143, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 370);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 41);
            label1.Name = "label1";
            label1.Size = new Size(198, 19);
            label1.TabIndex = 5;
            label1.Text = "Biblioteca Silenciosa";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RoyalBlue;
            menuStrip1.Font = new Font("Georgia", 9.75F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { librosToolStripMenuItem, autoresToolStripMenuItem, estudiantesToolStripMenuItem, prestamosToolStripMenuItem, toolStripMenuItem5 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(506, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(61, 20);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(68, 20);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // estudiantesToolStripMenuItem
            // 
            estudiantesToolStripMenuItem.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            estudiantesToolStripMenuItem.Size = new Size(96, 20);
            estudiantesToolStripMenuItem.Text = "Estudiantes";
            estudiantesToolStripMenuItem.Click += estudiantesToolStripMenuItem_Click;
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(89, 20);
            prestamosToolStripMenuItem.Text = "Prestamos ";
            prestamosToolStripMenuItem.Click += prestamosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(54, 20);
            toolStripMenuItem5.Text = "Salir";
            // 
            // dgv_Libros
            // 
            dgv_Libros.AllowUserToAddRows = false;
            dgv_Libros.AllowUserToDeleteRows = false;
            dgv_Libros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Libros.BackgroundColor = SystemColors.ActiveCaption;
            dgv_Libros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Libros.Location = new Point(3, 77);
            dgv_Libros.Name = "dgv_Libros";
            dgv_Libros.ReadOnly = true;
            dgv_Libros.Size = new Size(502, 290);
            dgv_Libros.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 459);
            Controls.Add(panel1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Menu";
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Libros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvLibros;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem estudiantesToolStripMenuItem;
        private ToolStripMenuItem prestamosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem5;
        private DataGridView dgv_Libros;
        private Label label1;
    }
}