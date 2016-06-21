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
    public partial class ConsultaSecciones : Form
    {
        private DataTable dt = new DataTable();
        private SqlDataAdapter a;
        private SqlConnection conn;
        private SqlCommand cmd;
        string strConn = string.Empty;

        public ConsultaSecciones()
        {
            InitializeComponent();
            strConn = @"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttomBuscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dt = new DataTable(); //El objeto que tendra los datos del datagridview


            /// Armando el query....
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM tblGrupos WHERE 1=1");
            if (this.textBoxNoGrupo.Text.TrimEnd().Length > 0)
                sql.Append(" AND NoGrupo=" + this.textBoxNoGrupo.Text.TrimEnd());
            if (this.textBoxAsignatura.Text.Trim().Length > 0)
                sql.Append(" AND ClaveAsignatura LIKE '%" + this.textBoxAsignatura.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBoxAula.Text.Trim().Length > 0)
                sql.Append(" AND Aula LIKE '%" + this.textBoxAula.Text.TrimEnd() + "%'");
            if (this.textBoxProfesor.Text.Trim().Length > 0)
                sql.Append(" AND  Profesor LIKE '%" + this.textBoxProfesor.Text.TrimEnd() + "%'");

          

            sql.Append(" ORDER BY ClaveAsignatura asc, NoGrupo, Aula, Profesor");

            ////Creando la conexion a la base de datos

            conn = new SqlConnection(strConn);
            cmd = new SqlCommand(sql.ToString(), conn); //El comando que manejara el query.
            a = new SqlDataAdapter(cmd); //El objeto que llenara el datagridview

            try
            {
                conn.Open();
                a.Fill(dt); //Rellena el datatable con la data que capture producto del query.

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            this.dataGridView1.AutoGenerateColumns = false; // Para que no tome las columnas automaticas del  datatable
            this.dataGridView1.DataSource = dt;  //Asignando la fuente de los datos...

            if (dt != null)
                textBoxCount.Text = dt.Rows.Count.ToString("#,###;;0"); //El conteo de los registros del query.

            Cursor.Current = Cursors.Default;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Secciones frm = new Secciones();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.buttomBuscar_Click(sender, e);
            }
            frm.Dispose();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNoGrupo.Text = string.Empty;
            this.textBoxAula.Text = string.Empty;
            this.textBoxAsignatura.Text = string.Empty;
            this.textBoxProfesor.Text = string.Empty;

            this.dataGridView1.DataSource = null;
            this.textBoxCount.Text = "0";
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
