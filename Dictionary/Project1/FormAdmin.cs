using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                this.Close();
            }
            if (e.Alt && e.KeyCode == Keys.U)
            {
                this.Close();
            }
            if (e.Alt && e.KeyCode == Keys.D)
            {
                this.Close();
            }
            if (e.Alt && e.KeyCode == Keys.L)
            {
                this.Close();
            }
        }
    }
}
