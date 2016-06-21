using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inscripsoft
{
    public partial class InscripSoft : Form
    {
        public InscripSoft()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InscripSoft_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/Rhadimer");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://WWW.twitter.com/Rhadimer_RD");
        }

        private void ButtonEstudiantes_Click(object sender, EventArgs e)
        {
            ConsultaEstudiantes frm = new ConsultaEstudiantes();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();

        }

        private void ButtonProfesores_Click(object sender, EventArgs e)
        {
            ConsultaProfesores frm = new ConsultaProfesores();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void ButtonAsignaturas_Click(object sender, EventArgs e)
        {
            ConsultaAsignaturas frm = new ConsultaAsignaturas();
            frm.Show();
        }

        private void ButtonAulas_Click(object sender, EventArgs e)
        {
            ConsultaAulas frm = new ConsultaAulas();
            frm.Show();
        }

        private void ButtonSecciones_Click(object sender, EventArgs e)
        {
            ConsultaSecciones frm = new ConsultaSecciones();
            frm.Show();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosEstudiantes frm = new DatosEstudiantes("");
            
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosProfesores frm = new DatosProfesores();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignaturas frm = new Asignaturas();
            frm.Show();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aulas frm = new Aulas();
            frm.Show();
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secciones frm = new Secciones();
            frm.Show();
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripcion frm = new Inscripcion();
            frm.Show();
        }

        private void ButtonPagos_Click(object sender, EventArgs e)
        {
            Pagos frm = new Pagos();
            frm.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEstudiantes frm = new ConsultaEstudiantes();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void profesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProfesores frm = new ConsultaProfesores();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void asignaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaAsignaturas frm = new ConsultaAsignaturas();
            frm.Show();
        }

        private void aulaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaAulas frm = new ConsultaAulas();
            frm.Show();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos frm = new Pagos();
            frm.Show();
        }

        private void seccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaSecciones frm = new ConsultaSecciones();
            frm.Show();
        }

        private void ButtonInscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion frm = new Inscripcion();
            frm.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos frm = new Pagos();
            frm.Show();
        }
    }
}
