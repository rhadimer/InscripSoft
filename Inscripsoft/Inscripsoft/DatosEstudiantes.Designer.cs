namespace Inscripsoft
{
    partial class DatosEstudiantes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEstudiantes));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxSector = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxEdificio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNoCasa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxOcupacion = new System.Windows.Forms.ComboBox();
            this.comboBoxNacionalidad = new System.Windows.Forms.ComboBox();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.maskedCedula = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCarrera = new System.Windows.Forms.TextBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSubirImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(35, 263);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(160, 30);
            this.buttonCancelar.TabIndex = 31;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.maskedCelular);
            this.groupBox2.Controls.Add(this.maskedTelefono);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxCiudad);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxSector);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxEdificio);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxNoCasa);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxCalle);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(40, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 287);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // maskedCelular
            // 
            this.maskedCelular.Location = new System.Drawing.Point(79, 94);
            this.maskedCelular.Mask = "(000)-000-000";
            this.maskedCelular.Name = "maskedCelular";
            this.maskedCelular.Size = new System.Drawing.Size(173, 20);
            this.maskedCelular.TabIndex = 20;
            // 
            // maskedTelefono
            // 
            this.maskedTelefono.Location = new System.Drawing.Point(79, 41);
            this.maskedTelefono.Mask = "(000)-000-0000";
            this.maskedTelefono.Name = "maskedTelefono";
            this.maskedTelefono.Size = new System.Drawing.Size(173, 20);
            this.maskedTelefono.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(342, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxCiudad.Location = new System.Drawing.Point(394, 147);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(173, 20);
            this.textBoxCiudad.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Sector";
            // 
            // textBoxSector
            // 
            this.textBoxSector.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSector.Location = new System.Drawing.Point(394, 94);
            this.textBoxSector.Name = "textBoxSector";
            this.textBoxSector.Size = new System.Drawing.Size(173, 20);
            this.textBoxSector.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(342, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Edificio";
            // 
            // textBoxEdificio
            // 
            this.textBoxEdificio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxEdificio.Location = new System.Drawing.Point(394, 41);
            this.textBoxEdificio.Name = "textBoxEdificio";
            this.textBoxEdificio.Size = new System.Drawing.Size(173, 20);
            this.textBoxEdificio.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "No. Casa";
            // 
            // textBoxNoCasa
            // 
            this.textBoxNoCasa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNoCasa.Location = new System.Drawing.Point(79, 245);
            this.textBoxNoCasa.Name = "textBoxNoCasa";
            this.textBoxNoCasa.Size = new System.Drawing.Size(173, 20);
            this.textBoxNoCasa.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Calle";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxCalle.Location = new System.Drawing.Point(79, 198);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(173, 20);
            this.textBoxCalle.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxEmail.Location = new System.Drawing.Point(79, 147);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(173, 20);
            this.textBoxEmail.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefono";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Orange;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
            this.buttonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.Location = new System.Drawing.Point(35, 227);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(160, 30);
            this.buttonLimpiar.TabIndex = 30;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Cyan;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(35, 191);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(160, 30);
            this.buttonGuardar.TabIndex = 29;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.comboBoxOcupacion);
            this.groupBox1.Controls.Add(this.comboBoxNacionalidad);
            this.groupBox1.Controls.Add(this.comboBoxEstadoCivil);
            this.groupBox1.Controls.Add(this.dateTimePicker1_fechaNacimiento);
            this.groupBox1.Controls.Add(this.maskedCedula);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCarrera);
            this.groupBox1.Controls.Add(this.comboBoxSexo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Location = new System.Drawing.Point(228, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 276);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Estudiante";
            // 
            // comboBoxOcupacion
            // 
            this.comboBoxOcupacion.FormattingEnabled = true;
            this.comboBoxOcupacion.Items.AddRange(new object[] {
            "Estudiante",
            "Trabajador"});
            this.comboBoxOcupacion.Location = new System.Drawing.Point(463, 154);
            this.comboBoxOcupacion.Name = "comboBoxOcupacion";
            this.comboBoxOcupacion.Size = new System.Drawing.Size(173, 21);
            this.comboBoxOcupacion.TabIndex = 43;
            // 
            // comboBoxNacionalidad
            // 
            this.comboBoxNacionalidad.FormattingEnabled = true;
            this.comboBoxNacionalidad.Items.AddRange(new object[] {
            "Doninicano",
            "Afgano",
            "Alemán",
            "Árabe",
            "Argentino",
            "Australiano",
            "Belga",
            "Boliviano",
            "Brasilero",
            "Camboyano",
            "Canadiense",
            "Chileno",
            "Chino",
            "Colombiano",
            "Coreano",
            "Costarricense",
            "Cubano",
            "Danés",
            "Ecuatoriano",
            "Egipcio",
            "Salvadoreño",
            "Español",
            "Estadounidense",
            "Estonio",
            "Etiope",
            "Filipino",
            "Finlandés",
            "Francés",
            "Galés",
            "Griego",
            "Guatemalteco",
            "Haitiano",
            "Holandés",
            "Hondureño",
            "Indonés",
            "Inglés",
            "Iraquí",
            "Iraní",
            "Irlandés",
            "Israelí",
            "Italiano",
            "Japonés",
            "Árabe",
            "Laosiano",
            "Laosiano",
            "Letón",
            "Letón",
            "Letonés",
            "Lituano",
            "Malayo",
            "Malayo",
            "Marroquí",
            "Árabe ",
            "Mexicano",
            "Nicaragüense",
            "Nicaragüense \t",
            "Noruega \t",
            "Noruega \t",
            "Nueva Zelanda",
            "Nueva Zelandia \t",
            "Neocelandesa \t",
            "Panameña \t",
            "Paraguayo",
            "Paraguaya \t",
            "Peruano",
            "Polaco",
            "Portugués",
            "Puertorriqueño",
            "Rumano",
            "Ruso",
            "Sueco",
            "Suizo",
            "Tailandés",
            "Taiwanes",
            "Turco",
            "Ucraniano",
            "Uruguayo",
            "Venezolano",
            "Vietnamita"});
            this.comboBoxNacionalidad.Location = new System.Drawing.Point(244, 155);
            this.comboBoxNacionalidad.Name = "comboBoxNacionalidad";
            this.comboBoxNacionalidad.Size = new System.Drawing.Size(173, 21);
            this.comboBoxNacionalidad.TabIndex = 42;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(26, 216);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(173, 21);
            this.comboBoxEstadoCivil.TabIndex = 26;
            // 
            // dateTimePicker1_fechaNacimiento
            // 
            this.dateTimePicker1_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_fechaNacimiento.Location = new System.Drawing.Point(26, 155);
            this.dateTimePicker1_fechaNacimiento.Name = "dateTimePicker1_fechaNacimiento";
            this.dateTimePicker1_fechaNacimiento.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1_fechaNacimiento.TabIndex = 25;
            // 
            // maskedCedula
            // 
            this.maskedCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCedula.Location = new System.Drawing.Point(463, 35);
            this.maskedCedula.Mask = "(000)-0000000-0";
            this.maskedCedula.Name = "maskedCedula";
            this.maskedCedula.Size = new System.Drawing.Size(173, 20);
            this.maskedCedula.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(308, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Balance";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(82, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Estado Civil";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBalance.Location = new System.Drawing.Point(244, 216);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(173, 20);
            this.textBoxBalance.TabIndex = 10;
            this.textBoxBalance.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cedula";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(524, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ocupación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nacionalidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Carrera";
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCarrera.Location = new System.Drawing.Point(244, 96);
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(173, 20);
            this.textBoxCarrera.TabIndex = 4;
            this.textBoxCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(463, 96);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(173, 21);
            this.comboBoxSexo.TabIndex = 5;
            this.comboBoxSexo.Tag = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matricula";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMatricula.Location = new System.Drawing.Point(26, 96);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(173, 20);
            this.textBoxMatricula.TabIndex = 3;
            this.textBoxMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre\'s";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombre.Location = new System.Drawing.Point(244, 35);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(173, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Apellidos";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxApellido.Location = new System.Drawing.Point(26, 35);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(173, 20);
            this.textBoxApellido.TabIndex = 0;
            this.textBoxApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSubirImagen
            // 
            this.buttonSubirImagen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubirImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubirImagen.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubirImagen.Image")));
            this.buttonSubirImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubirImagen.Location = new System.Drawing.Point(35, 155);
            this.buttonSubirImagen.Name = "buttonSubirImagen";
            this.buttonSubirImagen.Size = new System.Drawing.Size(160, 30);
            this.buttonSubirImagen.TabIndex = 28;
            this.buttonSubirImagen.Text = "Subir imagen";
            this.buttonSubirImagen.UseVisualStyleBackColor = false;
            this.buttonSubirImagen.Click += new System.EventHandler(this.buttonSubirImagen_Click);
            // 
            // DatosEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(928, 618);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSubirImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(934, 642);
            this.MinimumSize = new System.Drawing.Size(934, 642);
            this.Name = "DatosEstudiantes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedCelular;
        private System.Windows.Forms.MaskedTextBox maskedTelefono;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxSector;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxEdificio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNoCasa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxOcupacion;
        private System.Windows.Forms.ComboBox comboBoxNacionalidad;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_fechaNacimiento;
        private System.Windows.Forms.MaskedTextBox maskedCedula;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCarrera;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSubirImagen;
    }
}