using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaladDesktop
{
    public partial class Form1 : Form
    {
        private ClassSalad listObject;


        public Form1()
        {
            InitializeComponent();
            listObject = new ClassSalad();
        }


       



        private void button1_Click_1(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listObject.vegetableList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            label2.Text = listObject.TotalCalories().ToString();
        }

    void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listObject.vegetableList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            label2.Text = listObject.TotalCalories().ToString();

            AddForm addForm = new AddForm(this);
            addForm.Show();
            Close();
        }
    }

}
