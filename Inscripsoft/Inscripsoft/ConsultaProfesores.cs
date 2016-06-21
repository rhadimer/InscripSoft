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
    public partial class ConsultaProfesores : Form
    {
        private DataTable dt = new DataTable();
        private SqlDataAdapter a;
        private SqlConnection conn;
        private SqlCommand cmd;
        string strConn = string.Empty;


        public ConsultaProfesores()
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
            sql.Append("SELECT * FROM tblProfesores WHERE 1=1");
            if (this.textBoxID.Text.Trim().Length > 0)
                sql.Append(" AND ID=" + this.textBoxID.Text);
            if (this.textBoxNombre.Text.Trim().Length > 0)
                sql.Append(" AND Nombre LIKE '%" + this.textBoxNombre.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBoxApellidos.Text.Trim().Length > 0)
                sql.Append(" AND Apellido LIKE '%" + this.textBoxApellidos.Text.TrimEnd() + "%'");

            ///Para remover la mascara..
            string valor = this.maskedCedula.Text.Replace(this.maskedCedula.PromptChar, ' ');
            valor = valor.Replace('-', ' ').Trim();

            if (valor.Length > 0)
                sql.Append(" AND Cedula LIKE '%" + this.maskedCedula.Text.Replace(maskedCedula.PromptChar, ' ').Trim() + "%'");

            sql.Append(" ORDER BY Nombre asc, ID, Apellido, Cedula");

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
            this.textBoxApellidos.Text = string.Empty;
            this.textBoxNombre.Text = string.Empty;
            this.textBoxID.Text = string.Empty;
            this.dataGridView1.DataSource = null;
            this.textBoxCount.Text = "0";
            this.maskedCedula.Text = string.Empty;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            DatosProfesores frm = new DatosProfesores();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.buttomBuscar_Click(sender, e);
            }
            frm.Dispose();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = 0;
            if (dataGridView1.RowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int.TryParse(row.Cells[0].Value.ToString(), out valor);
                }
                if (valor > 0)
                {
                    DatosProfesores frm = new DatosProfesores();  //esto esta redudante, programar para eliminar redundancia
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        this.buttomBuscar_Click(sender, e);
                    }
                    frm.Dispose();
                }
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "ID LIKE '" + textBoxID.Text.TrimEnd() + "%'";
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "Nombre LIKE '%" + textBoxNombre.Text.TrimEnd() + "%'";
        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "Apellido LIKE '%" + textBoxApellidos.Text.TrimEnd() + "%'";
        }
    }
}
