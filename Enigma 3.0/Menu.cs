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

        private void Ceaser(object sender, EventArgs e)
        {
            Ceaser_Form main_m = new Ceaser_Form();
            this.Hide();
            main_m.Show();
        }

        private void Symmetric(object sender, EventArgs e)
        {
            Symmetric_Form main_s = new Symmetric_Form();
            this.Hide();
            main_s.Show();
        }

        private void Morze(object sender, EventArgs e)
        {
            Morze morze = new Morze();
            this.Hide();
            morze.Show();
        }
    }
}
