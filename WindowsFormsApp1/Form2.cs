using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class SamirFormulario1 : Form
    {
        public SamirFormulario1()
        {
            InitializeComponent();
        }

        public string title = null;
        public object localitation = null;
        public object type = null;
        public object criticilty = null;
        public object environment = null;
        public string description = null;
        public DateTime startDate;
        public decimal duration = 0;
        public object status = null;
        public decimal percentage = 0;
        public bool wantSendEmail = false;




        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            title = textBoxTitle.Text;
        }

        private void comboBoxLocalitation_SelectedIndexChanged(object sender, EventArgs e)
        {
            localitation = comboBoxLocalitation.SelectedItem;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = comboBoxType.SelectedItem;
        }

        private void SamirFormulario1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBoxEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> checkItems = new List<string>();
            environment = null;
            for (int i = 0; i < checkedListBoxEnvironment.Items.Count; i++)
            {
                if (checkedListBoxEnvironment.GetItemChecked(i) == true)
                {
                    environment += checkedListBoxEnvironment.Items[i].ToString() + " ";
                }
            }

        }
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            description = textBoxDescription.Text;
        }

        private void comboBoxCriticilty_SelectedIndexChanged(object sender, EventArgs e)
        {
            criticilty = comboBoxCriticilty.SelectedItem;
        }

        private void dateTimeStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dateTimeStartDate.Value;
        }

        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            duration = numericUpDownDuration.Value;
        }
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = comboBoxStatus.SelectedItem;
        }

        private void checkBoxWantSendEmail_CheckedChanged(object sender, EventArgs e)
        {
            wantSendEmail = checkBoxWantSendEmail.Checked;
        }

        private void numericUpDownPercentage_ValueChanged(object sender, EventArgs e)
        {
            percentage = numericUpDownPercentage.Value;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (description == "" || startDate == null || environment == null)
                MessageBox.Show("Description, start date and environment are required, please check your form.");
            else
            {
                MessageBox.Show($"Title: {title}\n" +
                    $"Localitation: {localitation}\n" +
                    $"Type: {type}\n" +
                    $"Criticity: {criticilty}\n" +
                    $"Environment: {environment}\n" +
                    $"Description: {description}\n" +
                    $"Start date: {startDate}\n" +
                    $"Duration (in hours): {duration}\n" +
                    $"Status: {status}\n" +
                    $"Percent complete: {percentage}\n" +
                    $"Want send and email: {wantSendEmail}");
            }

        }


    }
}
