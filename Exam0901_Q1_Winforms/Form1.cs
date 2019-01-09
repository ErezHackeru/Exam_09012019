using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam0901_Q1_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] RandNums = new int[5];
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {           

            InitiateLabels();

        }

        private void InitiateLabels()
        {            
            for (int i = 0; i < RandNums.Length; i++)
            {
                RandNums[i] = r.Next(21);
            }
            label1.Text = RandNums[0].ToString();
            label2.Text = RandNums[1].ToString();
            label3.Text = RandNums[2].ToString();
            label4.Text = RandNums[3].ToString();
            label5.Text = RandNums[4].ToString();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            label1.Visible=false;
            label2.Visible=false;
            label3.Visible=false;
            label4.Visible=false;
            label5.Visible = false;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (textBox1.Text == RandNums[0].ToString())
                score++;
            else
                textBox1.ForeColor = Color.Red;
            if (textBox2.Text == RandNums[1].ToString())
                score++;
            else
                textBox2.ForeColor = Color.Red;
            if (textBox4.Text == RandNums[2].ToString())
                score++;
            else
                textBox4.ForeColor = Color.Red; 
            if (textBox3.Text == RandNums[3].ToString())
                score++;
            else
                textBox3.ForeColor = Color.Red; 
            if (textBox5.Text == RandNums[4].ToString())
                score++;
            else
                textBox5.ForeColor = Color.Red; 

            listBox1.Items.Add(score);

            if ((textBox1.Text == RandNums[0].ToString()) && (textBox2.Text == RandNums[1].ToString()) &&
                (textBox4.Text == RandNums[2].ToString()) && (textBox3.Text == RandNums[3].ToString()) &&
                (textBox5.Text == RandNums[4].ToString()))
                MessageBox.Show("Winner ! all numbers remembered corectly !");
            else
                MessageBox.Show("You were wrong !");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitiateLabels();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();            
        }
    }
}
