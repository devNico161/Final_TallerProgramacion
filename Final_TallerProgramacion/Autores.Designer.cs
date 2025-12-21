namespace Final_TallerProgramacion
{
    partial class Autores
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
            BtnConfirmarBusqueda = new Button();
            BtnVolver = new Button();
            cmbAutores = new ComboBox();
            dgv_Autores = new DataGridView();
            label2 = new Label();
            textBuscarAutor = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Autores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BtnConfirmarBusqueda);
            panel1.Controls.Add(BtnVolver);
            panel1.Controls.Add(cmbAutores);
            panel1.Controls.Add(dgv_Autores);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBuscarAutor);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(108, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 356);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnConfirmarBusqueda
            // 
            BtnConfirmarBusqueda.BackColor = Color.LawnGreen;
            BtnConfirmarBusqueda.Cursor = Cursors.Hand;
            BtnConfirmarBusqueda.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmarBusqueda.Location = new Point(241, 58);
            BtnConfirmarBusqueda.Name = "BtnConfirmarBusqueda";
            BtnConfirmarBusqueda.Size = new Size(30, 23);
            BtnConfirmarBusqueda.TabIndex = 21;
            BtnConfirmarBusqueda.Text = "✅";
            BtnConfirmarBusqueda.UseVisualStyleBackColor = false;
            BtnConfirmarBusqueda.Click += BtnConfirmarBusqueda_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.RoyalBlue;
            BtnVolver.Cursor = Cursors.Hand;
            BtnVolver.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVolver.Location = new Point(3, 7);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(95, 35);
            BtnVolver.TabIndex = 17;
            BtnVolver.Text = "👈 Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // cmbAutores
            // 
            cmbAutores.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAutores.FormattingEnabled = true;
            cmbAutores.Items.AddRange(new object[] { "Nombre Del Autor", "Nacionalidad" });
            cmbAutores.Location = new Point(309, 57);
            cmbAutores.Name = "cmbAutores";
            cmbAutores.Size = new Size(110, 24);
            cmbAutores.TabIndex = 4;
            cmbAutores.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgv_Autores
            // 
            dgv_Autores.AllowUserToAddRows = false;
            dgv_Autores.AllowUserToDeleteRows = false;
            dgv_Autores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Autores.Location = new Point(3, 107);
            dgv_Autores.Name = "dgv_Autores";
            dgv_Autores.ReadOnly = true;
            dgv_Autores.Size = new Size(417, 246);
            dgv_Autores.TabIndex = 3;
            dgv_Autores.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 60);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 2;
            label2.Text = "Buscar🔎";
            // 
            // textBuscarAutor
            // 
            textBuscarAutor.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscarAutor.Location = new Point(101, 60);
            textBuscarAutor.Name = "textBuscarAutor";
            textBuscarAutor.Size = new Size(134, 21);
            textBuscarAutor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 10);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 0;
            label1.Text = "Menu de Autores";
            label1.Click += label1_Click;
            // 
            // Autores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Autores";
            Text = "Autores";
            Load += Autores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Autores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBuscarAutor;
        private Label label2;
        private DataGridView dgv_Autores;
        private ComboBox cmbAutores;
        private Button BtnVolver;
        private Button BtnConfirmarBusqueda;
    }
}