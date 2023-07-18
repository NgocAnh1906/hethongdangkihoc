using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hethongdangkihoc
{
    public partial class Hethongdangkihoc : Form
    {
        public Hethongdangkihoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangkihoc s = new dangkihoc();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phieubaothutien s = new phieubaothutien();
            s.Show();
        }
    }
}
