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
    public partial class Inscripcion : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;");
        public Inscripcion()
        {
            InitializeComponent();
            
        }

        private void buttomBuscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string cadsql = "select Nombre from tblEstudiantes where Matricula='" + textBoxMatricula.Text + "'";
            

            SqlCommand comando = new SqlCommand(cadsql,con);
           
            con.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {
               // MessageBox.Show("El registro se ha encontrado");
                textBoxNombre.Text = leer["Nombre"].ToString();
                
            }
            else 
            {
                MessageBox.Show("La Matricula No Existe");
                textBoxNombre.Text = "";
            }
            con.Close();
        }

        private VariablesAsignaturas GetDatosAsignatura(string clave)
        {
            VariablesAsignaturas r = new VariablesAsignaturas();

            string sql = string.Format("SELECT Clave,Descripcion,Creditos FROM tblAsignaturas WHERE Clave LIKE '{0}';", clave);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        r.Clave = reader["Clave"].ToString();
                        r.Descripcion = reader["Descripcion"].ToString();
                        r.Creditos = Convert.ToInt32(reader["Creditos"]);
                        ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


            return r;
        }


        private void dgvInscripcion_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string clave = (dgvInscripcion[0, e.RowIndex].Value == null ? string.Empty : dgvInscripcion[e.ColumnIndex, e.RowIndex].Value.ToString());
            VariablesAsignaturas i = GetDatosAsignatura(clave);
            if (i.Clave != null)
            {
                dgvInscripcion[1, e.RowIndex].Value = i.Descripcion;
                dgvInscripcion[2, e.RowIndex].Value = i.Creditos;
                txtTotalCreditos.Text = TotalColumna(this.dgvInscripcion, "colCreditos").ToString();

                // validar cantidad maxima de creditos
                int creditosAcumulados = Convert.ToInt32(txtTotalCreditos.Text);
                if (creditosAcumulados >= 25) //cantidad de creditos maximos 25
                {
                    MessageBox.Show("Sobre pasado el limite de Cantidad maxima de creditos = 25 debe eliminar clases");

                    //para detener la introduccion de datos
                    // dgvInscripcion.ColumnAdded(null)
                }
            }

            else
            //if(String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {

                MessageBox.Show("Asignatura no existente");
                dgvInscripcion[0, e.RowIndex].Value = this.Text = "";
                /// dgvInscripcion.Rows[e.RowIndex].ErrorText = "Error"; e.Cancel = true;

            }
        }


        int TotalColumna(DataGridView dgv, string nombreCol)
        {
            if (dgv == null)
                return 0;

            int total = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                total += Convert.ToInt32(row.Cells[nombreCol].Value);


            }
            return total;
        }


        private void dgvInscripcion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvInscripcion.Rows[e.RowIndex].ErrorText = String.Empty;
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
        
        
        //funcion obtenerdatos
        public DataTable Datos(string Clave)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;");
            
            string query = "SELECT  Clave, Descripcion, Creditos FROM tblAsignaturas WHERE Clave=@Clave";

            
            
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Clave",Clave);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            
        }

        private void dgvInscripcion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             //SqlCommand cmd = new SqlCommand();
           
            // DataGridViewRow row = dgvInscripcion.CurrentRow;
           
            //dgvInscripcion.DataSource = Datos(Convert.ToString(row.Cells["colClave"].Value));

        }

        private void dgvInscripcion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();

            DataGridViewRow row = dgvInscripcion.CurrentRow;

            dgvInscripcion.DataSource = Datos(Convert.ToString(row.Cells["colClave"].Value));
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblInscripcion VALUES(@Matricula, @NoSemestre, @ClaveAsignatura, @NoGrupo, @Fecha)", con);
                con.Open();


                foreach (DataGridViewRow row in dgvInscripcion.Rows)
                {
                    if (row.Cells["colClave"].Value != null)
                    {
                        //cmd.Parameters.Clear();
                        //cmd.Parameters.AddWithValue("@NoInscripcion", textBoxNoInscripcion.Text.TrimEnd());
                        cmd.Parameters.AddWithValue("@Matricula", textBoxMatricula.Text.TrimEnd());
                        cmd.Parameters.AddWithValue("@NoSemestre", textBoxSemestre.Text.TrimEnd());
                        cmd.Parameters.AddWithValue("@ClaveAsignatura", Convert.ToString(row.Cells["colClave"].Value));
                        cmd.Parameters.AddWithValue("@NoGrupo", textBoxNoGrupo.Text.TrimEnd());
                        cmd.Parameters.AddWithValue("@Fecha", dateTimePicker1.Text.TrimEnd());
                       
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Guardado Correctamente");
                    }

                    else
                    {
                        MessageBox.Show("No puede estar vacio");
                    }
                }


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
        }

        


    }
}
