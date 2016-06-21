using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inscripsoft
{
    public partial class DatosProfesores : Form
    {
        //private int ID = 0;
        public DatosProfesores(/*int ID*/)
        {
           
            InitializeComponent();
           /* this.ID = ID;
            if (ID > 0)
            {
                this.textBoxID.Text = ID.ToString();
              // this.textBoxID.TextAlign = ContentAlignment.MiddleCenter;
                
                
            }*/
               
            
        }

        

       

        //valida campo vacios
        private bool campoVacios()
        {
            if (textBoxApellido.Text == "")
                return true;
            else
                return false;
        }


        

        private void textBoxPrimerApellido_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBoxApellido, "El apellido No puede estar en blanco");
            else
                errorProvider1.SetError(textBoxApellido, "");
        }

        private void textBoxNombre_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBoxNombre, "El nombre No puede estar en blanco");
            else
                errorProvider1.SetError(textBoxNombre, "");
        }

        
         private void maskedCedula_Validated_1(object sender, EventArgs e)
        {
           bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(maskedCedula, "La cedula No puede estar en blanco");
            else
                errorProvider1.SetError(maskedCedula, "");
        }
        

        private void textBoxMatricula_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBoxID, "La matricula No puede estar en blanco");
            else
                errorProvider1.SetError(textBoxID, "");
        }

        private void textBoxCarrera_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBoxCarrera, "La carrera No puede estar en blanco");
            else
                errorProvider1.SetError(textBoxCarrera, "");
        }

        private void comboBoxSexo_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(comboBoxSexo, "El sexo No puede estar en blanco");
            else
                errorProvider1.SetError(comboBoxSexo, "");
        }

        private void dateTimePicker1_fechaNacimiento_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(dateTimePicker1_fechaNacimiento, "La fecha de nacimiento No puede estar en blanco");
            else
                errorProvider1.SetError(dateTimePicker1_fechaNacimiento, "");
        }

        private void comboBoxNacionalidad_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(comboBoxNacionalidad, "La nacionalidad No puede estar en blanco");
            else
                errorProvider1.SetError(comboBoxNacionalidad, "");
        }

        private void comboBoxOcupacion_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(comboBoxOcupacion, "La ocupacion No puede estar en blanco");
            else
                errorProvider1.SetError(comboBoxOcupacion, "");
        }

        private void comboBoxEstadoCivil_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(comboBoxEstadoCivil, "El estado civil No puede estar en blanco");
            else
                errorProvider1.SetError(comboBoxEstadoCivil, "");
        }

        private void textBoxBalance_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBoxBalance, "El balance No puede estar en blanco");
            else
                errorProvider1.SetError(textBoxBalance, "");
        }


        bool GuardarDatos()
        {

            bool ret = false;
            SqlConnection conexion = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure; // para almacenar desde un procedimiento almacenado
            cmd.CommandText = "Guard_Profesor";//  Guardar_Profesores


            cmd.Parameters.AddWithValue("@ID",textBoxID.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Nombre", textBoxNombre.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Apellido", textBoxApellido.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Sexo", comboBoxSexo.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Cedula", maskedCedula.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@TelefonoCasa", maskedTelefono.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Celular", maskedCelular.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Calle", textBoxCalle.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@NoCasa", textBoxNoCasa.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Edificio", textBoxEdificio.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Sector", textBoxSector.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Ciudad", textBoxCiudad.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Nacionalidad", comboBoxNacionalidad.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Ocupacion", comboBoxOcupacion.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Carrera", textBoxCarrera.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@FechaNacimiento", dateTimePicker1_fechaNacimiento.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@EstadoCivil", comboBoxEstadoCivil.Text.TrimEnd());
           




            // cmd.Parameters.Add("@Salida", SqlDbType.Int);
            // cmd.Parameters["@Salida"].Direction = ParameterDirection.Output;//se debe especificar que es output

            //  cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100);
            // cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;//se debe especificar que es output

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();

                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion.Close();
            }
            return ret;
        }



        private void buttonSubirImagen_Click(object sender, EventArgs e)
        {
           
            //subir imagenn
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            openFileDialog1.Dispose();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            // botom guardar


            //validando
            this.textBoxPrimerApellido_Validated(this, e);
            this.textBoxNombre_Validated(this, e);
            this.maskedCedula_Validated_1(this, e);
            this.textBoxMatricula_Validated(this, e);
            this.textBoxCarrera_Validated(this, e);
            comboBoxSexo_Validated(this, e);
            dateTimePicker1_fechaNacimiento_Validated(this, e);
            comboBoxNacionalidad_Validated(this, e);
            comboBoxOcupacion_Validated(this, e);
            comboBoxEstadoCivil_Validated(this, e);
            textBoxBalance_Validated(this, e);

            if (GuardarDatos())
            {
                MessageBox.Show("Informacion Guardada Satisfactoriamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                this.DialogResult = DialogResult.No;

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            
            // limpiar textbox

            this.textBoxApellido.Text = string.Empty;
            this.textBoxNombre.Text = string.Empty;
            this.textBoxID.Text = string.Empty;
            this.textBoxCarrera.Text = string.Empty;
            this.comboBoxSexo.Text = string.Empty;
            this.maskedCedula.Text = string.Empty;
            this.comboBoxOcupacion.Text = string.Empty;
            this.dateTimePicker1_fechaNacimiento.Text = string.Empty;
            this.comboBoxEstadoCivil.Text = string.Empty;
            this.textBoxBalance.Text = string.Empty;
            this.comboBoxNacionalidad.Text = string.Empty;
            this.maskedTelefono.Text = string.Empty;
            this.maskedCelular.Text = string.Empty;
            this.textBoxEmail.Text = string.Empty;
            this.textBoxCalle.Text = string.Empty;
            this.textBoxNoCasa.Text = string.Empty;
            this.textBoxEdificio.Text = string.Empty;
            this.textBoxSector.Text = string.Empty;
            this.textBoxCiudad.Text = string.Empty;
            this.pictureBox1.Image = null;
            errorProvider1.Clear();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        

        
    }
}
