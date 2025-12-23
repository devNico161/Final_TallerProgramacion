
namespace Final_TallerProgramacion
{
    partial class Login
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
            panel1 = new Panel();
            btnCrearCuenta = new Button();
            label1 = new Label();
            btnIniciarSesion = new Button();
            TextContraseña = new TextBox();
            TextUsuario = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnCrearCuenta);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnIniciarSesion);
            panel1.Controls.Add(TextContraseña);
            panel1.Controls.Add(TextUsuario);
            panel1.Controls.Add(lblContraseña);
            panel1.Controls.Add(lblUsuario);
            panel1.Location = new Point(258, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 265);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.LimeGreen;
            btnCrearCuenta.Cursor = Cursors.Hand;
            btnCrearCuenta.Font = new Font("Georgia", 9F, FontStyle.Bold);
            btnCrearCuenta.ForeColor = SystemColors.ControlText;
            btnCrearCuenta.Location = new Point(40, 210);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(187, 43);
            btnCrearCuenta.TabIndex = 6;
            btnCrearCuenta.Text = "CREAR CUENTA NUEVA";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Georgia", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(52, 182);
            label1.Name = "label1";
            label1.Size = new Size(175, 14);
            label1.TabIndex = 5;
            label1.Text = "¿Olvidaste tu contraseña?";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.RoyalBlue;
            btnIniciarSesion.Font = new Font("Georgia", 9F, FontStyle.Bold);
            btnIniciarSesion.Location = new Point(55, 137);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(162, 42);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "INICIAR SESION";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // TextContraseña
            // 
            TextContraseña.Font = new Font("Georgia", 9F, FontStyle.Bold);
            TextContraseña.Location = new Point(42, 94);
            TextContraseña.Name = "TextContraseña";
            TextContraseña.Size = new Size(185, 21);
            TextContraseña.TabIndex = 3;
            // 
            // TextUsuario
            // 
            TextUsuario.Font = new Font("Georgia", 9F, FontStyle.Bold);
            TextUsuario.Location = new Point(42, 40);
            TextUsuario.Name = "TextUsuario";
            TextUsuario.Size = new Size(185, 21);
            TextUsuario.TabIndex = 2;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Georgia", 9F, FontStyle.Bold);
            lblContraseña.Location = new Point(42, 76);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(102, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "CONTRASEÑA";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Georgia", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(42, 22);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUARIO";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función en desarrollo...");
        }

        #endregion

        private Panel panel1;
        private TextBox TextUsuario;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox TextContraseña;
        private Label label1;
        private Button btnIniciarSesion;
        private Button btnCrearCuenta;
        
    }
}
