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
    public partial class AddForm : Form
{
     Form1 form1;
    private ClassSalad listObject;


        public AddForm(Form1 owner)
    {
            form1 = owner;
            InitializeComponent();
            listObject = new ClassSalad();


        }
    private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedItem.ToString() == "Solanum")
            {
                var p = new Solanum();
                p.SetName(textBox1.Text);
                p.SetColor(textBox2.Text);
                p.SetCalories(Convert.ToInt32(textBox3.Text));
                p.SetRootLength(textBox4.Text);
                listObject.vegetableList.Add(p);
                form1.listBox1.Items.Add(listObject.vegetableList[listObject.vegetableList.Count - 1].GetName());
                form1.label2.Text = listObject.TotalCalories().ToString();
                this.Close();
            }
            if (comboBox1.SelectedItem.ToString() == "Potato")
            {
                var p = new Potato();
                p.SetName(textBox1.Text);
                p.SetColor(textBox2.Text);
                p.SetCalories(Convert.ToInt32(textBox3.Text));
                p.SetRootLength(textBox4.Text);
                p.SetTypeOfPotato(textBox5.Text);
                listObject.vegetableList.Add(p);
                form1.listBox1.Items.Add(listObject.vegetableList[listObject.vegetableList.Count - 1].GetName());
                form1.label2.Text = listObject.TotalCalories().ToString();
                this.Close();
            }
            if (comboBox1.SelectedItem.ToString() == "Beet")
            {
                var p = new Beet();
                p.SetName(textBox1.Text);
                p.SetColor(textBox2.Text);
                p.SetCalories(Convert.ToInt32(textBox3.Text));
                p.SetDiametr(Convert.ToInt32(textBox6.Text));
                listObject.vegetableList.Add(p);
                form1.listBox1.Items.Add(listObject.vegetableList[listObject.vegetableList.Count - 1].GetName());
                form1.label2.Text = listObject.TotalCalories().ToString();
                this.Close();
            }
        }
    
     private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Solanum")
            {
                label4.Enabled = true;
                textBox4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
            if (comboBox1.SelectedItem.ToString() == "Potato")
            {
                label4.Enabled = true;
                textBox4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = false;
            }
            if (comboBox1.SelectedItem.ToString() == "Beet")
            {
                label4.Enabled = true;
                textBox4.Enabled = true;
                label5.Enabled = false;
                label7.Enabled = false;
                label6.Enabled = true;
                textBox4.Enabled = false;
                textBox6.Enabled = true;
                textBox5.Enabled = false;
            }
        }

    private void AddForm_Load(object sender, EventArgs e)
    {
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
