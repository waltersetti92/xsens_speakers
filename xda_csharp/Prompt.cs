using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTwExample
{
    public partial class Prompt : Form
    {
  
        public Prompt()
        {
            InitializeComponent();
            string id;


        }

        private void Promt_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id= textBox1.Text;
            Form1 form1 = new Form1(textBox1.Text);
            form1.ShowDialog();
           // form1.ID = id;
           // MessageBox.Show(form1.ID);
            this.Close();

        }
    }
}
