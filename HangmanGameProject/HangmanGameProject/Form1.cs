using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media; 
using System.Windows.Forms;

namespace HangmanGameProject
{
    public partial class Form1 : Form
    {
        String[] words = {"Matrix", "Founder", "Restart", "Column", "Integer", "Vernacular", "Wendigo", "incite" , "Metaphysical" , "eidetic" };
        static Random randomseed = new Random();
        int randomNumber; 
        String asteriskText = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            start();    
         

            


        }

        public void button1_Click(object sender, EventArgs e)
        {

            int wordLength = words[randomNumber].Length;
            Boolean letterFound = false;
            Boolean letterFoundAgain = false; 
            int num = 0;
            int num2 = 0; 
            int count = wordLength;


            for (int v = 0; v < wordLength; v++)
            {
                //String replaceLetter = asteriskText.Substring(v, 1); 
                if (textBox1.Text.Equals(words[randomNumber].Substring(v,1)))
                {
                    letterFound = true;
                    num = v;
                    for(int c = 0; c < num; c++)
                    {
                        if(words[randomNumber].Substring(num,1).Equals(words[randomNumber].Substring(c,1)))
                        {
                            letterFoundAgain = true;
                            num2 = c; 
                        }
                    }
                    


                }










            }
            
                
            if (letterFound == true)
                {
                    
                label3.Text = "Yes! " + textBox1.Text + " is in the word!";
                String gone;
                String added; 
               

                    gone = asteriskText.Remove(num, 1);
                    added = gone.Insert(num, textBox1.Text); 
                    asteriskText = added;
                    label1.Text = added;
                    
                    if(letterFoundAgain == true)
                    {
                        gone = asteriskText.Remove(num2, 1);
                        added = gone.Insert(num2, textBox1.Text);
                        asteriskText = added;
                        label1.Text = added; 
                    }
                    if(label1.Text.Equals(words[randomNumber]))
                    {
                        
                        MessageBox.Show("You Win!");
                        
                    }




                //String replaced = asteriskText.Insert(num, textBox1.Text);
                //asteriskText = replaced;

                //label1.Text = asteriskText;





            }
                else
                {
                    label3.Text = "No! " + textBox1.Text + " is not in the word!";
                }

                


            








        }

        public void start()
        {
            randomNumber = randomseed.Next(11); 
            for (int i = 0; i < words[randomNumber].Length; i++)
            {
                asteriskText += "*";
            }
            label1.Text = asteriskText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            label1.Text = "";
            asteriskText = "";
            randomNumber = randomseed.Next(11); 
            

            for (int v = 0; v < words[randomNumber].Length; v++)
            {
                asteriskText += "*"; 
            }
            label1.Text = asteriskText; 

        }
    }
}
