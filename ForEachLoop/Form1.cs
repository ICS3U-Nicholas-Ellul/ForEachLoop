using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachLoop
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control aControl in this.Controls)
            {
                aControl.Cursor = Cursors.Hand;
            }
        }

        private void Controls_Load(object sender, EventArgs e)
        {

        }
    }
}
