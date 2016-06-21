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
    public partial class ConsultaAulas : Form
    {
        private DataTable dt = new DataTable();
        private SqlDataAdapter a;
        private SqlConnection conn;
        private SqlCommand cmd;
        string strConn = string.Empty;

        public ConsultaAulas()
        {
            InitializeComponent();
            strConn = @"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=INF420;Integrated security=true;User ID=rdm2; Password=123456789;";
        }

        private void buttomBuscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dt = new DataTable(); //El objeto que tendra los datos del datagridview


            /// Armando el query....
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM tblAulas WHERE 1=1");
            if (this.textBoxCodigo.Text.TrimEnd().Length > 0)
                sql.Append(" AND Codigo=" + this.textBoxCodigo.Text.TrimEnd());
            if (this.textBoxCapacidad.Text.Trim().Length > 0)
                sql.Append(" AND Capacidad LIKE '%" + this.textBoxCapacidad.Text.TrimEnd().TrimStart() + "%' ");
            if (this.comboBoxCentroUniversitario.Text.Trim().Length > 0)
                sql.Append(" AND Centro LIKE '%" + this.comboBoxCentroUniversitario.Text.TrimEnd() + "%'");

            
           

            sql.Append(" ORDER BY Codigo asc, Capacidad, Centro");

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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxCodigo.Text = string.Empty;
            this.textBoxCapacidad.Text = string.Empty;
            this.comboBoxCentroUniversitario.Text = string.Empty;
            this.dataGridView1.DataSource = null;
            this.textBoxCount.Text = "0";
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Aulas frm = new Aulas();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.buttomBuscar_Click(sender, e);
            }
            frm.Dispose();
        }
    }
}
