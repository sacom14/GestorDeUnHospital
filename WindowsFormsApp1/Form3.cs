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
    public partial class Form3 : Form
    {
        DateTime? dateSelected = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void OnSelectPais(object sender, EventArgs e)
        {
            textBoxPaisSeleccionado.Text = listBoxListaPaises.SelectedItem.ToString();
        }

        private void enHombre(object sender, EventArgs e)
        {
            bool esHombre = true;
            textBoxEsHombre.Text = esHombre.ToString();

        }

        private void enMujer(object sender, EventArgs e)
        {
            bool esHombre = false;
            textBoxEsHombre.Text = esHombre.ToString();

        }

        private void dateTimePickerToday_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePickerToday.Checked)
               textBoxShowDate.Text = "No hay fecha";
            else
                dateSelected = dateTimePickerToday.Value;
        }

        private void showDate(object sender, EventArgs e)
        {
            textBoxShowDate.Text = dateSelected.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxEsHombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
