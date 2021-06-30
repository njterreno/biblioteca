using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ScreenSplash : Form
    {
        public ScreenSplash()
        {
            InitializeComponent();
            tmrTiempo.Enabled = true;
            tmrTiempo.Interval = 3000;
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            tmrTiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

      
        
    }
}
