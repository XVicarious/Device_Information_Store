using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Device_Information_Store
{
    public partial class AddPersistantRoute : Form
    {
        public String destination { get; set; }
        public String mask { get; set; }
        public String gateway { get; set; }
        public AddPersistantRoute()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isInForm(textBox1.Text)) 
            {
                textBox1.ForeColor = Color.Red;
                button2.Enabled = false;
            } 
            else 
            {
                textBox1.ForeColor = Color.Black;
                destination = textBox1.Text;
                if (isInForm(textBox2.Text) && isInForm(textBox3.Text))
                {
                    button2.Enabled = true;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!isInForm(textBox3.Text))
            {
                textBox3.ForeColor = Color.Red;
                button2.Enabled = false;
            }
            else
            {
                textBox3.ForeColor = Color.Black;
                mask = textBox3.Text;
                if (isInForm(textBox2.Text) && isInForm(textBox1.Text))
                {
                    button2.Enabled = true;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!isInForm(textBox2.Text))
            {
                textBox2.ForeColor = Color.Red;
                button2.Enabled = false;
            }
            else
            {
                textBox2.ForeColor = Color.Black;
                gateway = textBox2.Text;
                if (isInForm(textBox1.Text) && isInForm(textBox3.Text))
                {
                    button2.Enabled = true;
                }
            }
        }

        private Boolean isInForm(String name)
        {
            string[] octs = name.Split('.');
            if (octs.Length != 4)
            {
                return false;
            }
            foreach (String s in octs)
            {
                if (s == "" || Int32.Parse(0 + s) > 255 || Int32.Parse(0 + s) < 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
