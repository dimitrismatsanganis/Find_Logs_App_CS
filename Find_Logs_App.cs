using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Find_Logs_App
{
    public partial class Find_Logs : Form
    {
        public Find_Logs()
        {
            InitializeComponent();
        }
        public void logs(string events)
        {
            FileInfo f1 = new FileInfo("logs.txt");
            StreamWriter sw = new StreamWriter("logs.txt", true);
            if (f1.Length == 0)
            {
                sw.Write("[" + DateTime.Now + "]" + events);
            }
            else if (f1.Length != 0)
            {
                sw.Write(Environment.NewLine + "[" + DateTime.Now + "]" + events);
            }
            sw.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            logs(" Label Clicked");
        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            logs(" Label's Text Changed Into  " + textBox1.Text);
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            logs(" Mouse Leaves Label");
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            logs(" Mouse Enters Label");
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            logs(" Textbox Clicked");
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            logs(" Mouse Enters Textbox");
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            logs(" Mouse Leaves Textbox");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            logs(" Textbox's Text Changed Into " + textBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            logs(" Radiobutton's Check Change");
        }

        private void radioButton1_TextChanged(object sender, EventArgs e)
        {
            logs(" Radiobutton's Text Changed Into " + textBox1.Text);
        }

        private void radioButton1_MouseEnter(object sender, EventArgs e)
        {
            logs(" Mouse Enters Radiobutton");
        }

        private void radioButton1_MouseLeave(object sender, EventArgs e)
        {
            logs(" Mouse Leaves Radiobutton");
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            logs(" Mouse Enters Panel");
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            logs(" Mouse Leaves Panel");
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            logs(" Panel Clicked");
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            logs(" Panel is Visible");
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            logs(" Combobox's DropDown");
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            logs(" Combobox's DropDown Closed");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            logs(" Combobox's Selection Changed");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            logs(" Combobox Clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logs(" Button Clicked");
            label1.Text = textBox1.Text;
            radioButton1.Text = textBox1.Text;
            button1.Text = textBox1.Text;
            panel1.Visible = true;
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            logs(" Mouse Enters Button");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            logs(" Mouse Leaves Button");
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            logs(" Button's Text Change Into " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("logs.txt", RichTextBoxStreamType.PlainText);
            richTextBox1.Visible = true;
        }
    }
}
