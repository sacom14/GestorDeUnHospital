using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class textBoxNombre : Form
    {
        string name= null;
        public textBoxNombre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            name = textBox.Text;
        }

        private void butSaberNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mi nombre es : " + name);
        }

        private void butNewForm_Click(object sender, EventArgs e)
        {
            SamirFormulario1 nuevoFormulario1 = new SamirFormulario1();
            nuevoFormulario1.Show();

        }

        private void OpenForm3(object sender, EventArgs e)
        {
            Form3 nuevoFormualario3 = new Form3();
            nuevoFormualario3.Show();
            //tambien se puede nuevoFormualrio3.ShowDialog();
            DialogResult res = nuevoFormualario3.ShowDialog();
        }
    }
}
