using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IznajmiAuto
{
    public partial class GlavnaForma : Form
    {       
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            Width = 900;
            Height = 600;
            FormIzbor frm = new FormIzbor();
            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

    }
}
