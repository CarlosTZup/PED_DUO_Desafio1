namespace Desafio1
{
    partial class Principal
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPresion = new ComboBox();
            txtSangre = new ComboBox();
            txtGenero = new ComboBox();
            txtPaciente = new TextBox();
            panel2 = new Panel();
            button5 = new Button();
            btnBuscar = new Button();
            btnPromedio = new Button();
            btnEliminar = new Button();
            btnRegistrar = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPresion);
            panel1.Controls.Add(txtSangre);
            panel1.Controls.Add(txtGenero);
            panel1.Controls.Add(txtPaciente);
            panel1.Location = new Point(987, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 338);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 254);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Presion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 194);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Sangre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 129);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Genero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 40);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre del  paciente";
            // 
            // txtPresion
            // 
            txtPresion.FormattingEnabled = true;
            txtPresion.Items.AddRange(new object[] { "Baja", "Media", "Alta" });
            txtPresion.Location = new Point(61, 277);
            txtPresion.Name = "txtPresion";
            txtPresion.Size = new Size(151, 28);
            txtPresion.TabIndex = 3;
            // 
            // txtSangre
            // 
            txtSangre.FormattingEnabled = true;
            txtSangre.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            txtSangre.Location = new Point(61, 217);
            txtSangre.Name = "txtSangre";
            txtSangre.Size = new Size(151, 28);
            txtSangre.TabIndex = 2;
            // 
            // txtGenero
            // 
            txtGenero.FormattingEnabled = true;
            txtGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            txtGenero.Location = new Point(64, 152);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(151, 28);
            txtGenero.TabIndex = 1;
            txtGenero.SelectedIndexChanged += txtGenero_SelectedIndexChanged;
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(33, 63);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(240, 27);
            txtPaciente.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnPromedio);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnRegistrar);
            panel2.Location = new Point(987, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 188);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(107, 141);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(179, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "button4";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(179, 34);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(94, 29);
            btnPromedio.TabIndex = 2;
            btnPromedio.Text = "button3";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(33, 85);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "button2";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(33, 34);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "button1";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(21, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(960, 532);
            panel3.TabIndex = 3;
            panel3.Paint += DrawString;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1299, 560);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Principal";
            Text = "Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox txtPresion;
        private ComboBox txtSangre;
        private ComboBox txtGenero;
        private TextBox txtPaciente;
        private Panel panel2;
        private Button button5;
        private Button btnBuscar;
        private Button btnPromedio;
        private Button btnEliminar;
        private Button btnRegistrar;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel3;
    }
}