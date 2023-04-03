using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == false)
                    {
                        cb.Checked = false;
                        
                    }
                    else
                    {
                        cb.Checked = false;
                        
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == false)
                    {
                        cb.Checked = true;

                    }
                    else
                    {
                        cb.Checked = true;

                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                { e.Handled = true; }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                { e.Handled = true; }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                { e.Handled = true; }
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                { e.Handled = true; }
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 4;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 20;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.MaxLength = 17;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.MaxLength = 7;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.MaxLength = 256;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {                      
            string txtTextBox1 = textBox1.Text;
            string txtComboBox2 = comboBox2.Text;
            string txtComboBox3 = comboBox3.Text;
            string txtComboBox4 = comboBox4.Text;
            string txtTextBox5 = textBox5.Text;
            string txtTextBox6 = textBox6.Text;
            string txtComboBox7 = comboBox7.Text;
            string txtComboBox8 = comboBox8.Text;
            string txtTextBox9 = textBox9.Text;
            string txtTextBox10 = textBox10.Text;


            DataGridViewRow novaLinha = new DataGridViewRow();

            novaLinha.CreateCells(dataGridView1);
            novaLinha.Cells[0].Value = txtTextBox1;
            novaLinha.Cells[1].Value = txtComboBox2;
            novaLinha.Cells[2].Value = txtComboBox3;
            novaLinha.Cells[3].Value = txtComboBox4;
            novaLinha.Cells[4].Value = txtTextBox5;
            novaLinha.Cells[5].Value = txtTextBox6;
            novaLinha.Cells[6].Value = txtComboBox7;
            novaLinha.Cells[7].Value = txtComboBox8;
            novaLinha.Cells[8].Value = txtTextBox9;
            novaLinha.Cells[9].Value = txtTextBox10;
            dataGridView1.Rows.Add(novaLinha);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
