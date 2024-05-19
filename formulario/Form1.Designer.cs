namespace formulario
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
            btnAtender = new Button();
            btnSalir = new Button();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(637, 10);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(151, 50);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(637, 521);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(151, 50);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 55);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(277, 259);
            lstMedicos.TabIndex = 2;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(328, 55);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(277, 259);
            lstPacientes.TabIndex = 3;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 323);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(593, 248);
            rtbInfoMedico.TabIndex = 4;
            rtbInfoMedico.Text = "";
            rtbInfoMedico.TextChanged += rtbInfoMedico_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Pacientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 24);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 6;
            label2.Text = "Personal Medico";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 627);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private Label label1;
        private Label label2;
    }
}
