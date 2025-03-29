namespace WinFormsApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            PacienteName = new TextBox();
            PacienteSurname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ProfesionalSurname = new TextBox();
            ProfesionalName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            Turno = new TextBox();
            label9 = new Label();
            label11 = new Label();
            Departamento = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label13 = new Label();
            Consultorio = new TextBox();
            Piso = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 50);
            label1.TabIndex = 0;
            label1.Text = "Datos de la consulta";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 71);
            label2.Name = "label2";
            label2.Size = new Size(127, 40);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // PacienteName
            // 
            PacienteName.BackColor = SystemColors.Window;
            PacienteName.Location = new Point(28, 129);
            PacienteName.Name = "PacienteName";
            PacienteName.Size = new Size(170, 23);
            PacienteName.TabIndex = 2;
            // 
            // PacienteSurname
            // 
            PacienteSurname.Location = new Point(224, 129);
            PacienteSurname.Name = "PacienteSurname";
            PacienteSurname.Size = new Size(170, 23);
            PacienteSurname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 155);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 155);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 279);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 279);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Nombre";
            // 
            // ProfesionalSurname
            // 
            ProfesionalSurname.Location = new Point(224, 253);
            ProfesionalSurname.Name = "ProfesionalSurname";
            ProfesionalSurname.Size = new Size(170, 23);
            ProfesionalSurname.TabIndex = 8;
            // 
            // ProfesionalName
            // 
            ProfesionalName.BackColor = SystemColors.Window;
            ProfesionalName.Location = new Point(28, 253);
            ProfesionalName.Name = "ProfesionalName";
            ProfesionalName.Size = new Size(170, 23);
            ProfesionalName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 195);
            label7.Name = "label7";
            label7.Size = new Size(165, 40);
            label7.TabIndex = 6;
            label7.Text = "Profesional";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 427);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 13;
            label8.Text = "Código";
            // 
            // Turno
            // 
            Turno.BackColor = SystemColors.Window;
            Turno.Location = new Point(28, 401);
            Turno.Name = "Turno";
            Turno.Size = new Size(170, 23);
            Turno.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 343);
            label9.Name = "label9";
            label9.Size = new Size(93, 40);
            label9.TabIndex = 11;
            label9.Text = "Turno";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(421, 155);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 17;
            label11.Text = "Departamento";
            // 
            // Departamento
            // 
            Departamento.BackColor = SystemColors.Window;
            Departamento.Location = new Point(421, 129);
            Departamento.Name = "Departamento";
            Departamento.Size = new Size(375, 23);
            Departamento.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(421, 71);
            label12.Name = "label12";
            label12.Size = new Size(147, 40);
            label12.TabIndex = 14;
            label12.Text = "Ubicación";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(626, 221);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 21;
            label10.Text = "Consultorio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(421, 221);
            label13.Name = "label13";
            label13.Size = new Size(29, 15);
            label13.TabIndex = 20;
            label13.Text = "Piso";
            // 
            // Consultorio
            // 
            Consultorio.Location = new Point(626, 195);
            Consultorio.Name = "Consultorio";
            Consultorio.Size = new Size(170, 23);
            Consultorio.TabIndex = 19;
            // 
            // Piso
            // 
            Piso.BackColor = SystemColors.Window;
            Piso.Location = new Point(421, 195);
            Piso.Name = "Piso";
            Piso.Size = new Size(170, 23);
            Piso.TabIndex = 18;
            Piso.TextChanged += Piso_TextChanged;
            Piso.KeyPress += Piso_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(696, 456);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 22;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(592, 456);
            button2.Name = "button2";
            button2.Size = new Size(98, 23);
            button2.TabIndex = 23;
            button2.Text = "Descartar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(696, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(488, 456);
            button3.Name = "button3";
            button3.Size = new Size(98, 23);
            button3.TabIndex = 25;
            button3.Text = "Configuración";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 491);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label13);
            Controls.Add(Consultorio);
            Controls.Add(Piso);
            Controls.Add(label11);
            Controls.Add(Departamento);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(Turno);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(ProfesionalSurname);
            Controls.Add(ProfesionalName);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PacienteSurname);
            Controls.Add(PacienteName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PacienteName;
        private TextBox PacienteSurname;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ProfesionalSurname;
        private TextBox ProfesionalName;
        private Label label7;
        private Label label8;
        private TextBox Turno;
        private Label label9;
        private Label label11;
        private TextBox Departamento;
        private Label label12;
        private Label label10;
        private Label label13;
        private TextBox Consultorio;
        private TextBox Piso;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}
