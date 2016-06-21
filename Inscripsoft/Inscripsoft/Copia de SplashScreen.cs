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
    public partial class SplashScreen1 : Form
    {
        public SplashScreen1()
        {
        
            InitializeComponent();

            Tiempo.Enabled = true;
            Tiempo.Interval = 3000;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
