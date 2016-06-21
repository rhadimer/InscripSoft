namespace Inscripsoft
{
    partial class Aulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aulas));
            this.comboBoxCentroUniversitario = new System.Windows.Forms.ComboBox();
            this.CantroUniversitariolabel9 = new System.Windows.Forms.Label();
            this.textBoxCapacidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCentroUniversitario
            // 
            this.comboBoxCentroUniversitario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCentroUniversitario.FormattingEnabled = true;
            this.comboBoxCentroUniversitario.Items.AddRange(new object[] {
            "CURNE (UASD - San Fco de Macoris)",
            "SEDE (UASD- Santo Domingo)",
            "CURSA (UASD - Santiago)",
            "CURSO (UASD - Barahona)",
            "CURNO (UASD - Mao)",
            "CURSE (UASD - Bonao)",
            "CURNA (UASD - Nagua)",
            "CURA (UASD - Puerto Plata)",
            "CURE (UASD - Higuey)",
            "CURVE (UASD - La Vega)",
            ""});
            this.comboBoxCentroUniversitario.Location = new System.Drawing.Point(114, 131);
            this.comboBoxCentroUniversitario.Name = "comboBoxCentroUniversitario";
            this.comboBoxCentroUniversitario.Size = new System.Drawing.Size(247, 21);
            this.comboBoxCentroUniversitario.TabIndex = 49;
            // 
            // CantroUniversitariolabel9
            // 
            this.CantroUniversitariolabel9.AutoSize = true;
            this.CantroUniversitariolabel9.Location = new System.Drawing.Point(12, 134);
            this.CantroUniversitariolabel9.Name = "CantroUniversitariolabel9";
            this.CantroUniversitariolabel9.Size = new System.Drawing.Size(96, 13);
            this.CantroUniversitariolabel9.TabIndex = 48;
            this.CantroUniversitariolabel9.Text = "CantroUniversitario";
            // 
            // textBoxCapacidad
            // 
            this.textBoxCapacidad.Location = new System.Drawing.Point(114, 94);
            this.textBoxCapacidad.Name = "textBoxCapacidad";
            this.textBoxCapacidad.Size = new System.Drawing.Size(124, 20);
            this.textBoxCapacidad.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Capacidad";
            // 
            // textBoxCodigoAula
            // 
            this.textBoxCodigoAula.Location = new System.Drawing.Point(114, 61);
            this.textBoxCodigoAula.Name = "textBoxCodigoAula";
            this.textBoxCodigoAula.Size = new System.Drawing.Size(124, 20);
            this.textBoxCodigoAula.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo Del Aula";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 134);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrar.Location = new System.Drawing.Point(441, 227);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(87, 38);
            this.buttonCerrar.TabIndex = 56;
            this.buttonCerrar.Text = "Cancelar";
            this.buttonCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(338, 227);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(87, 38);
            this.buttonGuardar.TabIndex = 55;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(171, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Registro De Aulas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 48);
            this.panel1.TabIndex = 64;
            // 
            // Aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxCentroUniversitario);
            this.Controls.Add(this.CantroUniversitariolabel9);
            this.Controls.Add(this.textBoxCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigoAula);
            this.Controls.Add(this.label1);
            this.Name = "Aulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Aulas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCentroUniversitario;
        private System.Windows.Forms.Label CantroUniversitariolabel9;
        private System.Windows.Forms.TextBox textBoxCapacidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}