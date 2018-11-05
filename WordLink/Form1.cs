using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordLink
{
    public partial class Form1 : Form
    {
        int index = 0;
        List<string> correctword = new List<string>();
        StringBuilder word = new StringBuilder(); //Concatenates strings
        List<Label> CurrentLetter = new List<Label>();
        int levelIndex=0;

        public Form1()
        {
            InitializeComponent();
            word.Append("____");
            CurrentLetter.Add(label1);
            CurrentLetter.Add(label2);
            CurrentLetter.Add(label3);
            CurrentLetter.Add(label4);
            correctword.Add("MEAT");
            correctword.Add("TIME");
        }

        void verify()
        {
            if (index == 4)
            {
                if (word.ToString() == correctword[levelIndex])
                {
                    //to handle exceptions
                    
                    MessageBox.Show("YOU WIN");
                    levelIndex++;
                    try
                    {
                        nextlevel(correctword[levelIndex]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("YOU WON THE GAME");
                    }      

                }
                else
                {
                    MessageBox.Show("YOU LOSE");
                }
                index = 0;
            }
        }

        

        void nextlevel(string word)
        {
            button1.Text = word[0].ToString();
            button5.Text = word[1].ToString();
            button6.Text = word[2].ToString();
            button7.Text = word[3].ToString();

            label1.Text = label2.Text = label3.Text = label4.Text = "_"; 

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            word[index] = Convert.ToChar(((Button)sender).Text);
            CurrentLetter[index].Text = ((Button)sender).Text;
            index++;
            verify();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            word[index] = Convert.ToChar(((Button)sender).Text);
            CurrentLetter[index].Text = ((Button)sender).Text;
            index++;
            verify();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            word[index] = Convert.ToChar(((Button)sender).Text);
            CurrentLetter[index].Text = ((Button)sender).Text;
            index++;
            verify();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            word[index] = Convert.ToChar(((Button)sender).Text);
            CurrentLetter[index].Text = ((Button)sender).Text;
            index++;
            verify();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            CurrentLetter[index].Text = ((Button)sender).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Main = new Main();
            this.Hide();
            Main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
