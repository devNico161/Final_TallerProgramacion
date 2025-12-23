namespace Final_TallerProgramacion
{
    partial class Libros
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
            Libro = new Panel();
            label2 = new Label();
            BtnConfirmarBusqueda = new Button();
            dgvF2MenuLibros = new DataGridView();
            CmbBuscarPor = new ComboBox();
            label1 = new Label();
            BtnVolver = new Button();
            textboxTitulo = new TextBox();
            textboxEditorial = new TextBox();
            textboxArea = new TextBox();
            textboxIdLibro = new TextBox();
            BtnAceptar = new Button();
            lblArea = new Label();
            lblEditorial = new Label();
            lblID = new Label();
            lblTitulo = new Label();
            BtnEliminarLibro = new Button();
            BtnEditarLibro = new Button();
            BtnAgregarLibro = new Button();
            TextBoxBuscarLibro = new TextBox();
            lblBuscarLibro = new Label();
            Libro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvF2MenuLibros).BeginInit();
            SuspendLayout();
            // 
            // Libro
            // 
            Libro.BackColor = SystemColors.ActiveCaption;
            Libro.Controls.Add(label2);
            Libro.Controls.Add(BtnConfirmarBusqueda);
            Libro.Controls.Add(dgvF2MenuLibros);
            Libro.Controls.Add(CmbBuscarPor);
            Libro.Controls.Add(label1);
            Libro.Controls.Add(BtnVolver);
            Libro.Controls.Add(textboxTitulo);
            Libro.Controls.Add(textboxEditorial);
            Libro.Controls.Add(textboxArea);
            Libro.Controls.Add(textboxIdLibro);
            Libro.Controls.Add(BtnAceptar);
            Libro.Controls.Add(lblArea);
            Libro.Controls.Add(lblEditorial);
            Libro.Controls.Add(lblID);
            Libro.Controls.Add(lblTitulo);
            Libro.Controls.Add(BtnEliminarLibro);
            Libro.Controls.Add(BtnEditarLibro);
            Libro.Controls.Add(BtnAgregarLibro);
            Libro.Controls.Add(TextBoxBuscarLibro);
            Libro.Controls.Add(lblBuscarLibro);
            Libro.Location = new Point(12, 35);
            Libro.Name = "Libro";
            Libro.Size = new Size(751, 363);
            Libro.TabIndex = 0;
            Libro.Paint += Libro_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 17);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 21;
            label2.Text = "Menu de Libros";
            // 
            // BtnConfirmarBusqueda
            // 
            BtnConfirmarBusqueda.BackColor = Color.LawnGreen;
            BtnConfirmarBusqueda.Cursor = Cursors.Hand;
            BtnConfirmarBusqueda.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmarBusqueda.Location = new Point(335, 59);
            BtnConfirmarBusqueda.Name = "BtnConfirmarBusqueda";
            BtnConfirmarBusqueda.Size = new Size(30, 23);
            BtnConfirmarBusqueda.TabIndex = 20;
            BtnConfirmarBusqueda.Text = "✅";
            BtnConfirmarBusqueda.UseVisualStyleBackColor = false;
            BtnConfirmarBusqueda.Click += BtnConfirmarBusqueda_Click;
            // 
            // dgvF2MenuLibros
            // 
            dgvF2MenuLibros.AllowUserToAddRows = false;
            dgvF2MenuLibros.AllowUserToDeleteRows = false;
            dgvF2MenuLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvF2MenuLibros.Location = new Point(3, 141);
            dgvF2MenuLibros.Name = "dgvF2MenuLibros";
            dgvF2MenuLibros.ReadOnly = true;
            dgvF2MenuLibros.Size = new Size(508, 218);
            dgvF2MenuLibros.TabIndex = 19;
            dgvF2MenuLibros.CellClick += dgvF2MenuLibros_CellClick;
            dgvF2MenuLibros.CellContentClick += dgvF2MenuLibros_CellContentClick;
            // 
            // CmbBuscarPor
            // 
            CmbBuscarPor.FormattingEnabled = true;
            CmbBuscarPor.Items.AddRange(new object[] { "Nombre", "ID", "Autor" });
            CmbBuscarPor.Location = new Point(390, 61);
            CmbBuscarPor.Name = "CmbBuscarPor";
            CmbBuscarPor.Size = new Size(121, 23);
            CmbBuscarPor.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(585, 106);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 17;
            label1.Text = "Datos del Libro";
            label1.Click += label1_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.RoyalBlue;
            BtnVolver.Cursor = Cursors.Hand;
            BtnVolver.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(15, 15);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(95, 35);
            BtnVolver.TabIndex = 16;
            BtnVolver.Text = "👈 Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // textboxTitulo
            // 
            textboxTitulo.Font = new Font("Consolas", 9F);
            textboxTitulo.Location = new Point(615, 190);
            textboxTitulo.Name = "textboxTitulo";
            textboxTitulo.Size = new Size(100, 22);
            textboxTitulo.TabIndex = 15;
            // 
            // textboxEditorial
            // 
            textboxEditorial.Font = new Font("Consolas", 9F);
            textboxEditorial.Location = new Point(615, 228);
            textboxEditorial.Name = "textboxEditorial";
            textboxEditorial.Size = new Size(100, 22);
            textboxEditorial.TabIndex = 14;
            // 
            // textboxArea
            // 
            textboxArea.Font = new Font("Consolas", 9F);
            textboxArea.Location = new Point(616, 267);
            textboxArea.Name = "textboxArea";
            textboxArea.Size = new Size(100, 22);
            textboxArea.TabIndex = 13;
            // 
            // textboxIdLibro
            // 
            textboxIdLibro.Font = new Font("Consolas", 9F);
            textboxIdLibro.Location = new Point(615, 151);
            textboxIdLibro.Name = "textboxIdLibro";
            textboxIdLibro.Size = new Size(100, 22);
            textboxIdLibro.TabIndex = 12;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.RoyalBlue;
            BtnAceptar.Cursor = Cursors.Hand;
            BtnAceptar.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnAceptar.Location = new Point(585, 311);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(80, 31);
            BtnAceptar.TabIndex = 11;
            BtnAceptar.Text = "ACEPTAR";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += button1_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblArea.Location = new Point(539, 275);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(35, 14);
            lblArea.TabIndex = 10;
            lblArea.Text = "Area";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblEditorial.Location = new Point(539, 236);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(70, 14);
            lblEditorial.TabIndex = 9;
            lblEditorial.Text = "Editorial";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblID.Location = new Point(539, 159);
            lblID.Name = "lblID";
            lblID.Size = new Size(49, 14);
            lblID.TabIndex = 8;
            lblID.Text = "Codigo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblTitulo.Location = new Point(539, 198);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(49, 14);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Titulo";
            // 
            // BtnEliminarLibro
            // 
            BtnEliminarLibro.BackColor = Color.RoyalBlue;
            BtnEliminarLibro.Cursor = Cursors.Hand;
            BtnEliminarLibro.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnEliminarLibro.Location = new Point(282, 100);
            BtnEliminarLibro.Name = "BtnEliminarLibro";
            BtnEliminarLibro.Size = new Size(83, 35);
            BtnEliminarLibro.TabIndex = 6;
            BtnEliminarLibro.Text = "Eliminar";
            BtnEliminarLibro.UseVisualStyleBackColor = false;
            BtnEliminarLibro.Click += BtnEliminarLibro_Click;
            // 
            // BtnEditarLibro
            // 
            BtnEditarLibro.BackColor = Color.RoyalBlue;
            BtnEditarLibro.Cursor = Cursors.Hand;
            BtnEditarLibro.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnEditarLibro.Location = new Point(151, 100);
            BtnEditarLibro.Name = "BtnEditarLibro";
            BtnEditarLibro.Size = new Size(106, 35);
            BtnEditarLibro.TabIndex = 5;
            BtnEditarLibro.Text = "Editar Libro";
            BtnEditarLibro.UseVisualStyleBackColor = false;
            BtnEditarLibro.Click += BtnEditarLibro_Click;
            // 
            // BtnAgregarLibro
            // 
            BtnAgregarLibro.BackColor = Color.RoyalBlue;
            BtnAgregarLibro.Cursor = Cursors.Hand;
            BtnAgregarLibro.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnAgregarLibro.Location = new Point(27, 100);
            BtnAgregarLibro.Name = "BtnAgregarLibro";
            BtnAgregarLibro.Size = new Size(99, 35);
            BtnAgregarLibro.TabIndex = 4;
            BtnAgregarLibro.Text = "Nuevo Libro";
            BtnAgregarLibro.UseVisualStyleBackColor = false;
            BtnAgregarLibro.Click += BtnAgregarLibro_Click;
            // 
            // TextBoxBuscarLibro
            // 
            TextBoxBuscarLibro.Font = new Font("Consolas", 9F);
            TextBoxBuscarLibro.Location = new Point(132, 60);
            TextBoxBuscarLibro.Name = "TextBoxBuscarLibro";
            TextBoxBuscarLibro.Size = new Size(199, 22);
            TextBoxBuscarLibro.TabIndex = 2;
            // 
            // lblBuscarLibro
            // 
            lblBuscarLibro.AutoSize = true;
            lblBuscarLibro.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarLibro.Location = new Point(3, 61);
            lblBuscarLibro.Name = "lblBuscarLibro";
            lblBuscarLibro.Size = new Size(123, 20);
            lblBuscarLibro.TabIndex = 1;
            lblBuscarLibro.Text = "Buscar Libro🔎";
            lblBuscarLibro.Click += lblBuscarLibro_Click;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(Libro);
            Name = "Libros";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Libros";
            Load += Libros_Load;
            Libro.ResumeLayout(false);
            Libro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvF2MenuLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Libro;
        private Label lblBuscarLibro;
        private TextBox TextBoxBuscarLibro;
        private Button BtnEliminarLibro;
        private Button BtnEditarLibro;
        private Button BtnAgregarLibro;
        private Label lblTitulo;
        private Label lblArea;
        private Label lblEditorial;
        private Label lblID;
        private Button BtnAceptar;
        private TextBox textboxIdLibro;
        private TextBox textboxTitulo;
        private TextBox textboxEditorial;
        private TextBox textboxArea;
        private Button BtnVolver;
        private Label label1;
        private ComboBox CmbBuscarPor;
        private DataGridView dgvF2MenuLibros;
        private Button BtnConfirmarBusqueda;
        private Label label2;
    }
}