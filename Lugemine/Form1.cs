using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lugemine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password manager 1.0.\n Mikifriki"); // tekitab tekstikasti
            //Stringis nagu üleval paneb tähis \n järgmise teksti järgmisele reale.
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactIDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactIDDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactIDDataSet.People);

        }

        private void contactIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
