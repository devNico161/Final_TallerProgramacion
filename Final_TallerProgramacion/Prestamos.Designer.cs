namespace Final_TallerProgramacion
{
    partial class Prestamos
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
            dgvPendientes = new DataGridView();
            label6 = new Label();
            btnDevolver = new Button();
            checkLisLibros = new CheckedListBox();
            dtmFechaDevolucion = new DateTimePicker();
            dtmFechaInicio = new DateTimePicker();
            btnRegistrar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbSeleccionEstudiante = new ComboBox();
            label1 = new Label();
            BtnVolver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dgvPendientes);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnDevolver);
            panel1.Controls.Add(checkLisLibros);
            panel1.Controls.Add(dtmFechaDevolucion);
            panel1.Controls.Add(dtmFechaInicio);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbSeleccionEstudiante);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 443);
            panel1.TabIndex = 0;
            // 
            // dgvPendientes
            // 
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientes.Location = new Point(493, 202);
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.Size = new Size(291, 184);
            dgvPendientes.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(597, 178);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 31;
            label6.Text = "Estado de libros";
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.RoyalBlue;
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnDevolver.Location = new Point(238, 392);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(106, 35);
            btnDevolver.TabIndex = 30;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // checkLisLibros
            // 
            checkLisLibros.FormattingEnabled = true;
            checkLisLibros.Location = new Point(11, 202);
            checkLisLibros.Name = "checkLisLibros";
            checkLisLibros.Size = new Size(333, 184);
            checkLisLibros.TabIndex = 29;
            // 
            // dtmFechaDevolucion
            // 
            dtmFechaDevolucion.Location = new Point(317, 135);
            dtmFechaDevolucion.Name = "dtmFechaDevolucion";
            dtmFechaDevolucion.Size = new Size(200, 23);
            dtmFechaDevolucion.TabIndex = 28;
            // 
            // dtmFechaInicio
            // 
            dtmFechaInicio.Location = new Point(317, 89);
            dtmFechaInicio.Name = "dtmFechaInicio";
            dtmFechaInicio.Size = new Size(200, 23);
            dtmFechaInicio.TabIndex = 27;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.RoyalBlue;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnRegistrar.Location = new Point(38, 392);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 35);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(151, 178);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 25;
            label5.Text = "Lista de libros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(354, 115);
            label4.Name = "label4";
            label4.Size = new Size(127, 17);
            label4.TabIndex = 24;
            label4.Text = "Fecha de Devolucion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(375, 69);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 23;
            label3.Text = "Fecha de Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 66);
            label2.Name = "label2";
            label2.Size = new Size(150, 17);
            label2.TabIndex = 22;
            label2.Text = "Selecciona un estudiante:";
            // 
            // cmbSeleccionEstudiante
            // 
            cmbSeleccionEstudiante.FormattingEnabled = true;
            cmbSeleccionEstudiante.Location = new Point(60, 77);
            cmbSeleccionEstudiante.Name = "cmbSeleccionEstudiante";
            cmbSeleccionEstudiante.Size = new Size(144, 23);
            cmbSeleccionEstudiante.TabIndex = 21;
            cmbSeleccionEstudiante.SelectedIndexChanged += cmbSeleccionEstudiante_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 10);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 20;
            label1.Text = "Registro de Prestamos";
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.RoyalBlue;
            BtnVolver.Cursor = Cursors.Hand;
            BtnVolver.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(11, 8);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(95, 35);
            BtnVolver.TabIndex = 19;
            BtnVolver.Text = "👈 Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Prestamos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Prestamos";
            Load += Prestamos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnVolver;
        private ComboBox cmbSeleccionEstudiante;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnRegistrar;
        private CheckedListBox checkLisLibros;
        private DateTimePicker dtmFechaDevolucion;
        private DateTimePicker dtmFechaInicio;
        private Button btnDevolver;
        private DataGridView dgvPendientes;
        private Label label6;
    }
}