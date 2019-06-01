using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_3._0
{
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }

        Ceaser_Form cf = new Ceaser_Form();
        Symmetric_Form sf = new Symmetric_Form();
        Morze m = new Morze();

        private void Ceaser(object sender, EventArgs e)
        {
            this.Hide();
            cf.Show();
        }

        private void Symmetric(object sender, EventArgs e)
        {
            this.Hide();
            sf.Show();
        }

        private void Morze(object sender, EventArgs e)
        {
            this.Hide();
            m.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
