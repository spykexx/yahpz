using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random ran = new Random(DateTime.Now.Millisecond);
        public int RollsNumber = 0;
        
        int StoreDiceOne(int x, int y)
        {
           

            if (y == 1)
            {
                int firstRoll = x;
               // MessageBox.Show(firstRoll.ToString());
                textBox2.Text = firstRoll.ToString();
            }
            else if (y == 2)
            {
                int secondRoll = x;
               // MessageBox.Show(secondRoll.ToString());
                textBox3.Text = secondRoll.ToString();
            }
            else if (y == 3)
            {
                int thirdRoll = x;
                //MessageBox.Show(thirdRoll.ToString());
                textBox4.Text = thirdRoll.ToString();
            }
            return (x);
        }

        void RollDice_Click(object sender, EventArgs e)
        {
            RollsNumber++;
            
            int Dice1 = 0;
        


                int rnumber = ran.Next(1, 7);
                int rnumber2 = ran.Next(1, 7);
                int rnumber3 = ran.Next(1, 7);
                int rnumber4 = ran.Next(1, 7);
                int rnumber5 = ran.Next(1, 7);

                int Dice2;
                int Dice3;
                int Dice4;
                int Dice5;

                int i = 0;
                int[] RandNums = { rnumber, rnumber2, rnumber3, rnumber4, rnumber5 };

                foreach (int rr in RandNums)
                {

                    #region Dice 1 Function
                    if (rr == 1 && i == 0)
                    {
                        if (chkOne.Checked)
                        {

                        }
                        else
                        {

                            Class2.p1 = panel1;
                            Class2.DrawClear();
                            Class2.DrawDice1();
                            Class2.p1 = panel6;
                            Dice1 = 1;
                            StoreDiceOne(Dice1, RollsNumber);
                        }
                    }
                    else if (rr == 2 && i == 0)
                    {
                        if (chkOne.Checked)
                        {

                        }
                        else
                        {
                            Class2.p1 = panel1;
                            Class2.DrawClear();
                            Class2.DrawDice2();
                            Class2.p1 = panel6;
                            Dice1 = 2;
                            StoreDiceOne(Dice1, RollsNumber);
                        }
                    }
                    else if (rr == 3 && i == 0)
                    {
                        if (chkOne.Checked)
                        {

                        }
                        else
                        {
                            Class2.p1 = panel1;
                            Class2.DrawClear();
                            Class2.DrawDice3();
                            Class2.p1 = panel6;
                            Dice1 = 3;
                            StoreDiceOne(Dice1, RollsNumber);
                        }
                    }
                    else if (rr == 4 && i == 0)
                    {
                        if (chkOne.Checked)
                        {

                        }
                        else
                        {
                            Class2.p1 = panel1;
                            Class2.DrawClear();
                            Class2.DrawDice4();
                            Class2.p1 = panel6;
                            Dice1 = 4;
                            StoreDiceOne(Dice1, RollsNumber);
                        }
                    }
                    else if (rr == 5 && i == 0)
                    {
                        if (chkOne.Checked)
                        {

                        }
                        else
                        {
                            Class2.p1 = panel1;
                            Class2.DrawClear();
                            Class2.DrawDice5();
                            Class2.p1 = panel6;
                            Dice1 = 5;
                            StoreDiceOne(Dice1, RollsNumber);
                        }
                    }
                    else if (rr == 6 && i == 0)
                    {
                        if (chkOne.Checked)
                        {

                        }
                        else
                        {

                            Class2.p1 = panel1;
                            Class2.DrawClear();
                            Class2.DrawDice6();
                            Class2.p1 = panel6;
                            Dice1 = 6;
                            StoreDiceOne(Dice1, RollsNumber);
                        }
                    }
                    #endregion
                    #region Dice 2 Function
                    if (rr == 1 && i == 1)
                    {
                        if (chkTwo.Checked)
                        {

                        }
                        else
                        {
                            Class2.p2 = panel2;
                            Class2.DrawClear();
                            Class2.DrawDice1();
                            Class2.p2 = panel6;
                        }
                    }
                    if (rr == 2 && i == 1)
                    {
                        if (chkTwo.Checked)
                        {

                        }
                        else
                        {
                            Class2.p2 = panel2;
                            Class2.DrawClear();
                            Class2.DrawDice2();
                            Class2.p2 = panel6;
                        }

                    }
                    if (rr == 3 && i == 1)
                    {
                        if (chkTwo.Checked)
                        {

                        }
                        else
                        {
                            Class2.p2 = panel2;
                            Class2.DrawClear();
                            Class2.DrawDice3();
                            Class2.p2 = panel6;
                        }
                    }
                    if (rr == 4 && i == 1)
                    {
                        if (chkTwo.Checked)
                        {

                        }
                        else
                        {
                            Class2.p2 = panel2;
                            Class2.DrawClear();
                            Class2.DrawDice4();
                            Class2.p2 = panel6;
                        }
                    }
                    if (rr == 5 && i == 1)
                    {
                        if (chkTwo.Checked)
                        {

                        }
                        else
                        {
                            Class2.p2 = panel2;
                            Class2.DrawClear();
                            Class2.DrawDice5();
                            Class2.p2 = panel6;
                        }
                    }
                    if (rr == 6 && i == 1)
                    {
                        if (chkTwo.Checked)
                        {

                        }
                        else
                        {
                            Class2.p2 = panel2;
                            Class2.DrawClear();
                            Class2.DrawDice6();
                            Class2.p2 = panel6;
                        }
                    }
                    #endregion
                    #region Dice 3 Function
                    if (rr == 1 && i == 2)
                    {
                        if (chkThree.Checked)
                        {

                        }
                        else
                        {
                            Class2.p3 = panel3;
                            Class2.DrawClear();
                            Class2.DrawDice1();
                            Class2.p3 = panel6;
                        }
                    }
                    if (rr == 2 && i == 2)
                    {
                        if (chkThree.Checked)
                        {

                        }
                        else
                        {
                            Class2.p3 = panel3;
                            Class2.DrawClear();
                            Class2.DrawDice2();
                            Class2.p3 = panel6;
                        }
                    }
                    if (rr == 3 && i == 2)
                    {
                        if (chkThree.Checked)
                        {

                        }
                        else
                        {
                            Class2.p3 = panel3;
                            Class2.DrawClear();
                            Class2.DrawDice3();
                            Class2.p3 = panel6;
                        }
                    }
                    if (rr == 4 && i == 2)
                    {
                        if (chkThree.Checked)
                        {

                        }
                        else
                        {
                            Class2.p3 = panel3;
                            Class2.DrawClear();
                            Class2.DrawDice4();
                            Class2.p3 = panel6;
                        }
                    }
                    if (rr == 5 && i == 2)
                    {
                        if (chkThree.Checked)
                        {

                        }
                        else
                        {
                            Class2.p3 = panel3;
                            Class2.DrawClear();
                            Class2.DrawDice5();
                            Class2.p3 = panel6;
                        }
                    }
                    if (rr == 6 && i == 2)
                    {
                        if (chkThree.Checked)
                        {

                        }
                        else
                        {
                            Class2.p3 = panel3;
                            Class2.DrawClear();
                            Class2.DrawDice6();
                            Class2.p3 = panel6;
                        }
                    }
                    #endregion
                    #region Dice 4 Function
                    if (rr == 1 && i == 3)
                    {
                        if (chkFour.Checked)
                        {

                        }
                        else
                        {
                            Class2.p4 = panel4;
                            Class2.DrawClear();
                            Class2.DrawDice1();
                            Class2.p4 = panel6;
                        }
                    }
                    if (rr == 2 && i == 3)
                    {
                        if (chkFour.Checked)
                        {

                        }
                        else
                        {
                            Class2.p4 = panel4;
                            Class2.DrawClear();
                            Class2.DrawDice2();
                            Class2.p4 = panel6;
                        }
                    }
                    if (rr == 3 && i == 3)
                    {
                        if (chkFour.Checked)
                        {

                        }
                        else
                        {
                            Class2.p4 = panel4;
                            Class2.DrawClear();
                            Class2.DrawDice3();
                            Class2.p4 = panel6;
                        }
                    }
                    if (rr == 4 && i == 3)
                    {
                        if (chkFour.Checked)
                        {

                        }
                        else
                        {
                            Class2.p4 = panel4;
                            Class2.DrawClear();
                            Class2.DrawDice4();
                            Class2.p4 = panel6;
                        }
                    }
                    if (rr == 5 && i == 3)
                    {
                        if (chkFour.Checked)
                        {

                        }
                        else
                        {
                            Class2.p4 = panel4;
                            Class2.DrawClear();
                            Class2.DrawDice5();
                            Class2.p4 = panel6;
                        }
                    }
                    if (rr == 6 && i == 3)
                    {
                        if (chkFour.Checked)
                        {

                        }
                        else
                        {
                            Class2.p4 = panel4;
                            Class2.DrawClear();
                            Class2.DrawDice6();
                            Class2.p4 = panel6;
                        }
                    }
                    #endregion
                    #region Dice 5 Function
                    if (rr == 1 && i == 4)
                    {
                        if (chkFive.Checked)
                        {

                        }
                        else
                        {
                            Class2.p5 = panel5;
                            Class2.DrawClear();
                            Class2.DrawDice1();
                            Class2.p5 = panel6;
                        }
                    }
                    if (rr == 2 && i == 4)
                    {
                        if (chkFive.Checked)
                        {

                        }
                        else
                        {
                            Class2.p5 = panel5;
                            Class2.DrawClear();
                            Class2.DrawDice2();
                            Class2.p5 = panel6;
                        }
                    }
                    if (rr == 3 && i == 4)
                    {
                        if (chkFive.Checked)
                        {

                        }
                        else
                        {
                            Class2.p5 = panel5;
                            Class2.DrawClear();
                            Class2.DrawDice3();
                            Class2.p5 = panel6;
                        }
                    }
                    if (rr == 4 && i == 4)
                    {
                        if (chkFive.Checked)
                        {

                        }
                        else
                        {
                            Class2.p5 = panel5;
                            Class2.DrawClear();
                            Class2.DrawDice4();
                            Class2.p5 = panel6;
                        }
                    }
                    if (rr == 5 && i == 4)
                    {
                        if (chkFive.Checked)
                        {

                        }
                        else
                        {
                            Class2.p5 = panel5;
                            Class2.DrawClear();
                            Class2.DrawDice5();
                            Class2.p5 = panel6;
                        }
                    }
                    if (rr == 6 && i == 4)
                    {
                        if (chkFive.Checked)
                        {

                        }
                        else
                        {
                            Class2.p5 = panel5;
                            Class2.DrawClear();
                            Class2.DrawDice6();
                            Class2.p5 = panel6;
                        }
                    }
                    #endregion

                    i++;
                }
                lblRolls.Text = RollsNumber.ToString();
                lblInstruct.Visible = true;
            
                if (RollsNumber == 3)
                {
                    RollDice.Enabled = false;
                    lblInstruct.Visible = true;
                    lblInstruct.Text = "Chose how you wish to score your roll!";
                }
                //Class2.DrawDice6();
                if (rnumber == rnumber2 && rnumber == rnumber3 && rnumber == rnumber4 && rnumber == rnumber5)
                {
                    MessageBox.Show("YahpZ!");

                }
            
        
            }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        // #region Clear Dice On Click
        /* MyCode:
             {

             Class2.p1 = panel1;
             Class2.p2 = panel2;
             Class2.p3 = panel3;
             Class2.p4 = panel4;
             Class2.p5 = panel5;
             Class2.DrawClear();
             Class2.p1 = panel6;
             Class2.p2 = panel6;
             Class2.p3 = panel6;
             Class2.p4 = panel6;
             Class2.p5 = panel6;
                 #endregion
             }*/

    }
    
}
