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
    public partial class Secciones : Form
    {
        public Secciones()
        {
            InitializeComponent();
        }

        bool GuardarDatos()
        {

            bool ret = false;
            SqlConnection conexion = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure; // para almacenar desde un procedimiento almacenado
            cmd.CommandText = "dbo.Guardar_Grupos";//  Guardar_Estudiante


            cmd.Parameters.AddWithValue("@NoGrupos", textBoxNoGrupos.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@ClaveAsignatura", textBoxClaveAsignatura.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Aula", textBoxAula.Text.TrimEnd());
            cmd.Parameters.AddWithValue("@Profesor", textBoxProfesor.Text.TrimEnd());
          



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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarDatos())
            {
                MessageBox.Show("Informacion Guardada Satisfactoriamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                this.DialogResult = DialogResult.No;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
