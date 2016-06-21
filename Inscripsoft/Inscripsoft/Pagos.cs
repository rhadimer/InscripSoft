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
    public partial class Pagos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;");
        public Pagos()
        {
            InitializeComponent();
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

        bool GuardarDatos()
        {

            bool ret = false;
            SqlConnection conexion = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure; // para almacenar desde un procedimiento almacenado
            cmd.CommandText = "dbo.Guardar_Pagos";//  Guardar_Pagos


            cmd.Parameters.AddWithValue("@Matricula", textBoxMatricula.Text.ToString());
            cmd.Parameters.AddWithValue("@Monto", textBoxMonto.Text.ToString());
            cmd.Parameters.AddWithValue("@Fecha", dateTimePicker_Fecha.Text);
            cmd.Parameters.AddWithValue("@Centro", cboxCentroUniversitario.Text.ToString());
            cmd.Parameters.AddWithValue("@Creado", dateTimePicker_Creacion.Text);
            cmd.Parameters.AddWithValue("@Concepto", textBoxConcepto.Text.ToString());







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
    }
}
