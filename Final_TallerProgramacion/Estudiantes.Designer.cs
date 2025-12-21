namespace Final_TallerProgramacion
{
    partial class Estudiantes
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
            panel1 = new Panel();
            lblResPromedio = new Label();
            cmbEstudiant = new ComboBox();
            btnPromedio = new Button();
            dgvEstudiantes = new DataGridView();
            textboxEdad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textboxNombre = new TextBox();
            textboxDireccion = new TextBox();
            textboxCarrera = new TextBox();
            textboxCodig = new TextBox();
            BtnAceptar = new Button();
            lblArea = new Label();
            lblEditorial = new Label();
            lblID = new Label();
            lblTitulo = new Label();
            BtnEliminarEstud = new Button();
            BtnEditarEst = new Button();
            BtnAgregarEst = new Button();
            BtnConfirmarBusqueda = new Button();
            textBuscarEstud = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnVolver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblResPromedio);
            panel1.Controls.Add(cmbEstudiant);
            panel1.Controls.Add(btnPromedio);
            panel1.Controls.Add(dgvEstudiantes);
            panel1.Controls.Add(textboxEdad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textboxNombre);
            panel1.Controls.Add(textboxDireccion);
            panel1.Controls.Add(textboxCarrera);
            panel1.Controls.Add(textboxCodig);
            panel1.Controls.Add(BtnAceptar);
            panel1.Controls.Add(lblArea);
            panel1.Controls.Add(lblEditorial);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(BtnEliminarEstud);
            panel1.Controls.Add(BtnEditarEst);
            panel1.Controls.Add(BtnAgregarEst);
            panel1.Controls.Add(BtnConfirmarBusqueda);
            panel1.Controls.Add(textBuscarEstud);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 447);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblResPromedio
            // 
            lblResPromedio.AutoSize = true;
            lblResPromedio.Location = new Point(554, 79);
            lblResPromedio.Name = "lblResPromedio";
            lblResPromedio.Size = new Size(38, 15);
            lblResPromedio.TabIndex = 41;
            lblResPromedio.Text = "label5";
            // 
            // cmbEstudiant
            // 
            cmbEstudiant.FormattingEnabled = true;
            cmbEstudiant.Items.AddRange(new object[] { "Menor Edad", "Mayor Edad", "Edad > Al Promedio" });
            cmbEstudiant.Location = new Point(317, 71);
            cmbEstudiant.Name = "cmbEstudiant";
            cmbEstudiant.Size = new Size(121, 23);
            cmbEstudiant.TabIndex = 40;
            cmbEstudiant.SelectedIndexChanged += cmbEstudiant_SelectedIndexChanged;
            // 
            // btnPromedio
            // 
            btnPromedio.BackColor = Color.RoyalBlue;
            btnPromedio.Cursor = Cursors.Hand;
            btnPromedio.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnPromedio.Location = new Point(465, 44);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(83, 50);
            btnPromedio.TabIndex = 39;
            btnPromedio.Text = "Promedio de Edades";
            btnPromedio.UseVisualStyleBackColor = false;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(9, 162);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.Size = new Size(462, 277);
            dgvEstudiantes.TabIndex = 38;
            dgvEstudiantes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textboxEdad
            // 
            textboxEdad.Font = new Font("Consolas", 9F);
            textboxEdad.Location = new Point(568, 371);
            textboxEdad.Name = "textboxEdad";
            textboxEdad.Size = new Size(100, 22);
            textboxEdad.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label4.Location = new Point(492, 379);
            label4.Name = "label4";
            label4.Size = new Size(35, 14);
            label4.TabIndex = 36;
            label4.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(492, 180);
            label3.Name = "label3";
            label3.Size = new Size(180, 18);
            label3.TabIndex = 35;
            label3.Text = "Datos del Estudiante";
            // 
            // textboxNombre
            // 
            textboxNombre.Font = new Font("Consolas", 9F);
            textboxNombre.Location = new Point(568, 255);
            textboxNombre.Name = "textboxNombre";
            textboxNombre.Size = new Size(100, 22);
            textboxNombre.TabIndex = 34;
            // 
            // textboxDireccion
            // 
            textboxDireccion.Font = new Font("Consolas", 9F);
            textboxDireccion.Location = new Point(568, 293);
            textboxDireccion.Name = "textboxDireccion";
            textboxDireccion.Size = new Size(100, 22);
            textboxDireccion.TabIndex = 33;
            // 
            // textboxCarrera
            // 
            textboxCarrera.Font = new Font("Consolas", 9F);
            textboxCarrera.Location = new Point(569, 332);
            textboxCarrera.Name = "textboxCarrera";
            textboxCarrera.Size = new Size(100, 22);
            textboxCarrera.TabIndex = 32;
            // 
            // textboxCodig
            // 
            textboxCodig.Font = new Font("Consolas", 9F);
            textboxCodig.Location = new Point(568, 216);
            textboxCodig.Name = "textboxCodig";
            textboxCodig.Size = new Size(100, 22);
            textboxCodig.TabIndex = 31;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.RoyalBlue;
            BtnAceptar.Cursor = Cursors.Hand;
            BtnAceptar.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnAceptar.Location = new Point(553, 408);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(80, 31);
            BtnAceptar.TabIndex = 30;
            BtnAceptar.Text = "ACEPTAR";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblArea.Location = new Point(492, 340);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(56, 14);
            lblArea.TabIndex = 29;
            lblArea.Text = "Carrera";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblEditorial.Location = new Point(492, 301);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(70, 14);
            lblEditorial.TabIndex = 28;
            lblEditorial.Text = "Direccion";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblID.Location = new Point(492, 224);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 14);
            lblID.TabIndex = 27;
            lblID.Text = "CI";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblTitulo.Location = new Point(492, 263);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(49, 14);
            lblTitulo.TabIndex = 26;
            lblTitulo.Text = "Nombre";
            // 
            // BtnEliminarEstud
            // 
            BtnEliminarEstud.BackColor = Color.RoyalBlue;
            BtnEliminarEstud.Cursor = Cursors.Hand;
            BtnEliminarEstud.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnEliminarEstud.Location = new Point(287, 112);
            BtnEliminarEstud.Name = "BtnEliminarEstud";
            BtnEliminarEstud.Size = new Size(83, 35);
            BtnEliminarEstud.TabIndex = 25;
            BtnEliminarEstud.Text = "Eliminar";
            BtnEliminarEstud.UseVisualStyleBackColor = false;
            // 
            // BtnEditarEst
            // 
            BtnEditarEst.BackColor = Color.RoyalBlue;
            BtnEditarEst.Cursor = Cursors.Hand;
            BtnEditarEst.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnEditarEst.Location = new Point(156, 112);
            BtnEditarEst.Name = "BtnEditarEst";
            BtnEditarEst.Size = new Size(106, 35);
            BtnEditarEst.TabIndex = 24;
            BtnEditarEst.Text = "Editar ";
            BtnEditarEst.UseVisualStyleBackColor = false;
            BtnEditarEst.Click += BtnEditarEst_Click;
            // 
            // BtnAgregarEst
            // 
            BtnAgregarEst.BackColor = Color.RoyalBlue;
            BtnAgregarEst.Cursor = Cursors.Hand;
            BtnAgregarEst.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnAgregarEst.Location = new Point(32, 112);
            BtnAgregarEst.Name = "BtnAgregarEst";
            BtnAgregarEst.Size = new Size(99, 35);
            BtnAgregarEst.TabIndex = 23;
            BtnAgregarEst.Text = "Agregar";
            BtnAgregarEst.UseVisualStyleBackColor = false;
            BtnAgregarEst.Click += BtnAgregarEst_Click;
            // 
            // BtnConfirmarBusqueda
            // 
            BtnConfirmarBusqueda.BackColor = Color.LawnGreen;
            BtnConfirmarBusqueda.Cursor = Cursors.Hand;
            BtnConfirmarBusqueda.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmarBusqueda.Location = new Point(268, 71);
            BtnConfirmarBusqueda.Name = "BtnConfirmarBusqueda";
            BtnConfirmarBusqueda.Size = new Size(30, 23);
            BtnConfirmarBusqueda.TabIndex = 22;
            BtnConfirmarBusqueda.Text = "✅";
            BtnConfirmarBusqueda.UseVisualStyleBackColor = false;
            // 
            // textBuscarEstud
            // 
            textBuscarEstud.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscarEstud.Location = new Point(128, 73);
            textBuscarEstud.Name = "textBuscarEstud";
            textBuscarEstud.Size = new Size(134, 21);
            textBuscarEstud.TabIndex = 21;
            textBuscarEstud.TextChanged += textBuscarLibro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 20;
            label2.Text = "Buscar🔎";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 17);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 19;
            label1.Text = "Menu de Estudiantes";
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.RoyalBlue;
            BtnVolver.Cursor = Cursors.Hand;
            BtnVolver.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(17, 13);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(95, 35);
            BtnVolver.TabIndex = 18;
            BtnVolver.Text = "👈 Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            // 
            // Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Estudiantes";
            Text = "Estudiantes";
            Load += Estudiantes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnVolver;
        private Label label1;
        private Label label2;
        private TextBox textBuscarEstud;
        private Button BtnConfirmarBusqueda;
        private Button BtnEliminarEstud;
        private Button BtnEditarEst;
        private Button BtnAgregarEst;
        private Label label3;
        private TextBox textboxNombre;
        private TextBox textboxDireccion;
        private TextBox textboxCarrera;
        private TextBox textboxCodig;
        private Button BtnAceptar;
        private Label lblArea;
        private Label lblEditorial;
        private Label lblID;
        private Label lblTitulo;
        private DataGridView dgvEstudiantes;
        private TextBox textboxEdad;
        private Label label4;
        private ComboBox cmbEstudiant;
        private Button btnPromedio;
        private Label lblResPromedio;
    }
}