/**********************************
 ***Author: Del_Aguila_Daniel
 ***Date: October, 18th 2018
 **********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        const int MAX = 10;
        string[] quizNumber = { "Quiz 1", "Quiz 2", "Quiz 3", "Quiz 4", "Quiz 5", "Quiz 6", "Quiz 7", "Quiz 8", "Quiz 9", "Quiz 10"};
        double[] qMarks = new double[MAX];
        int quizCounter = 0;
        //double midtermGrade;
        //double finalExamGrade;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //The following will add quizzes into the list box
            double scores;
            double[] subtotal = new double[MAX];
            //int arr = 0;

            try
            {
                scores = Convert.ToDouble(txtQuiz.Text);
                qMarks[quizCounter] = scores;
                quizCounter++;
                GetQuizzList(quizNumber, qMarks, quizCounter);  //Calling the add quizzes method
            }
            //Will prevent the user from entering more than 10 quizzes
            catch
                (IndexOutOfRangeException ex)
            {
                MessageBox.Show("No more quizzes allowed!", "Error", MessageBoxButtons.OK);
                this.txtQuiz.Enabled = false;   //This will de-activate the Quiz textbox after maximum no. of quizzes entered
                this.btnAdd.Enabled = false;    //This will de-activate the button add after maximum no. of quizzes entered
            }

            this.txtQuiz.Clear();
        }
        
        //The following method will add quizzes entered
        private void GetQuizzList(string[] n, double[] p, int count)
        {
            lstQuizzes.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                lstQuizzes.Items.Add(n[i] + "\t" + p[i].ToString());
            }
        }

        //public double FindLowest()
        //{
        //    double qMarks = 0;
        //    for (int i = 0; i < qMarks; i++)
        //    {
        //        qMarks += quizCounter[1] * quizNumber[i]
        //    }
        //}        
        
        /*
        // TWO PARAMS: an array of numbers of type double (same as qMarks)
        // and an int value indicating the number of elements in the qMarks array
        
        public double find_lowest(double[] arr, int elements) 
        {
          // set lowest to a potentially high value in the array
          double lowest = 100.00;
          
          for(int i = 0; i < elements; i++) 
          { 
            // check if current element is lower than lowest
            if(arr[i] < lowest) 
            {              
              lowest = arr[i];
            }
          }
          // the method returns the lowest value in the array
          return lowest;
        }  
        */
        
        
        //The following method is used to make the math to attain the percentage of the quizzes.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ////////Variables for the Grade textboxes
            ////double grade1;
            ////double grade2;
            ////double grade3;
            double quizNumber1 = Convert.ToDouble(txtMidTermGrade.Text);
            double quizNumber2 = Convert.ToDouble(txtFinalExamGrade.Text); ;
            //double quizNumber3 = Convert.ToDouble(txtQuiz.Text); ;
            double midtermGrade;
            double finalExamGrade;

            ////////Variables for the Letter Grade textboxes
            //string letterGrade1;
            //string letterGrade2;
            //string letterGrade3;
            //string midtermLetterGrade;
            //string finalExamLetterGrade;

            ////////Converting the double variables to be written in textboxes
            ////double grade1 = Convert.ToDouble(txtQuiz.Text);
            ////double grade2 = Convert.ToDouble(txtQuiz.Text);
            ////double grade3 = Convert.ToDouble(txtQuiz.Text);
            midtermGrade = Convert.ToDouble(txtMidTermGrade.Text);
            finalExamGrade = Convert.ToDouble(txtFinalExamGrade.Text);

            double gradePct1 = (double)quizNumber1 * 15 / 100;
            double gradePct2 = (double)quizNumber2 * 15 / 100;
            //double gradePct3 = (double)quizNumber3 * 15 / 100;

            //////Formulas for obtaining Grade percentages
            //double gradePct1 = (double)grade1 * 15 / 100;
            //double gradePct2 = (double)grade2 * 15 / 100;
            //double gradePct3 = (double)grade3 * 15 / 100;

            //double midtermPct = (double)midtermGrade * 30 / 100;
            //double finalExamPct = (double)finalExamGrade * 40 / 100;

            ////////Variable that drops the lowest of the three quizzes
            //string lowestGradeDropped = "N/A";

            double quizSum;
            double midtermPct;
            double finalExamPct;
            quizSum = 0;

            for (int i = 0; i <= 9; i++)
            {
                quizSum = quizSum + qMarks[i];
                midtermGrade = midtermGrade * 30 / 100;
                finalExamGrade = finalExamGrade * 40 / 100;
            }

            quizSum = quizSum * 3.3333 / 100;
            //quizSum = quizSum * 3.3333 / 100 / 10;
            midtermPct = (double)midtermGrade * 30 / 100;
            finalExamPct = (double)finalExamGrade * 40 / 100;

            txtFinalGrade.Text = quizSum.ToString("p");

            //Formulas for obtaining the Final Grade
            //double finalGrade1SumPct = gradePct1 + gradePct2 + midtermPct + finalExamPct;
            //double finalGrade2SumPct = gradePct1 + gradePct3 + midtermPct + finalExamPct;
            //double finalGrade3SumPct = gradePct1 + gradePct2 + midtermPct + finalExamPct;

            //Formulas for obtaining the Final Grade
            //double finalGrade1SumPct = gradePct2 + gradePct3 + midtermPct + finalExamPct;
            //double finalGrade2SumPct = gradePct1 + gradePct3 + midtermPct + finalExamPct;
            //double finalGrade3SumPct = gradePct1 + gradePct2 + midtermPct + finalExamPct;

            //If/Else statements for the 1st Quizz that displays the Grade% and Letter Grade achieved
            //if (grade1 >= 90 && grade1 <= 100)
            //{
            //    letterGrade1 = "A";                     //The Letter Grade assigned to the Grade score
            //    txtGrade1Pct.Text = gradePct1.ToString("N2"); //It restricts the value by two decimals
            //}

            //else if (grade1 >= 80 && grade1 < 90)
            //{
            //    letterGrade1 = "B";
            //    txtGrade1Pct.Text = gradePct1.ToString("N2");
            //}

            //else if (grade1 >= 70 && grade1 < 80)
            //{
            //    letterGrade1 = "C";
            //    txtGrade1Pct.Text = gradePct1.ToString("N2");
            //}

            //else if (grade1 >= 60 && grade1 < 70)
            //{
            //    letterGrade1 = "D";
            //    txtGrade1Pct.Text = gradePct1.ToString("N2");
            //}

            //else
            //{
            //    letterGrade1 = "F";
            //    txtGrade1Pct.Text = gradePct1.ToString("N2");
            //}

            ////If/Else statements for the 2nd Quizz that displays the Grade% and Letter Grade achieved
            //if (grade2 >= 90 && grade2 <= 100)
            //{
            //    letterGrade2 = "A";
            //    txtGrade2Pct.Text = gradePct2.ToString("N2");
            //}

            //else if (grade2 >= 80 && grade2 < 90)
            //{
            //    letterGrade2 = "B";
            //    txtGrade2Pct.Text = gradePct2.ToString("N2");
            //}

            //else if (grade2 >= 70 && grade2 < 80)
            //{
            //    letterGrade2 = "C";
            //    txtGrade2Pct.Text = gradePct2.ToString("N2");
            //}

            //else if (grade2 >= 60 && grade2 < 70)
            //{
            //    letterGrade2 = "D";
            //    txtGrade2Pct.Text = gradePct2.ToString("N2");
            //}

            //else
            //{
            //    letterGrade2 = "F";
            //    txtGrade2Pct.Text = gradePct2.ToString("N2");
            //}

            ////If/Else statements for the 3rd Quizz that displays the Grade% and Letter Grade achieved
            //if (grade3 >= 90 && grade3 <= 100)
            //{
            //    letterGrade3 = "A";
            //    txtGrade3Pct.Text = gradePct3.ToString("N2");
            //}

            //else if (grade3 >= 80 && grade3 < 90)
            //{
            //    letterGrade3 = "B";
            //    txtGrade3Pct.Text = gradePct3.ToString("N2");
            //}

            //else if (grade3 >= 70 && grade3 < 80)
            //{
            //    letterGrade3 = "C";
            //    txtGrade3Pct.Text = gradePct3.ToString("N2");
            //}

            //else if (grade3 >= 60 && grade3 < 70)
            //{
            //    letterGrade3 = "D";
            //    txtGrade3Pct.Text = gradePct3.ToString("N2");
            //}

            //else
            //{
            //    letterGrade3 = "F";
            //    txtGrade3Pct.Text = gradePct3.ToString("N2");
            //}

            ////If/Else statements for the Midterm that displays the Grade% and Letter Grade achieved
            //if (midtermGrade >= 90 && midtermGrade <= 100)
            //{
            //    midtermLetterGrade = "A";
            //    txtMidTermPct.Text = midtermPct.ToString("N2");
            //}

            //else if (midtermGrade >= 80 && midtermGrade < 90)
            //{
            //    midtermLetterGrade = "B";
            //    txtMidTermPct.Text = midtermPct.ToString("N2");
            //}

            //else if (midtermGrade >= 70 && midtermGrade < 80)
            //{
            //    midtermLetterGrade = "C";
            //    txtMidTermPct.Text = midtermPct.ToString("N2");
            //}

            //else if (midtermGrade >= 60 && midtermGrade < 70)
            //{
            //    midtermLetterGrade = "D";
            //    txtMidTermPct.Text = midtermPct.ToString("N2");
            //}

            //else
            //{
            //    midtermLetterGrade = "F";
            //    txtMidTermPct.Text = midtermPct.ToString("N2");
            //}

            ////If/Else statements for the Final Exam that displays the Grade% and Letter Grade achieved
            //if (finalExamGrade >= 90 && finalExamGrade <= 100)
            //{
            //    finalExamLetterGrade = "A";
            //    txtFinalExamPct.Text = finalExamPct.ToString("N2");
            //}

            //else if (finalExamGrade >= 80 && finalExamGrade < 90)
            //{
            //    finalExamLetterGrade = "B";
            //    txtFinalExamPct.Text = finalExamPct.ToString("N2");
            //}

            //else if (finalExamGrade >= 70 && finalExamGrade < 80)
            //{
            //    finalExamLetterGrade = "C";
            //    txtFinalExamPct.Text = finalExamPct.ToString("N2");
            //}

            //else if (finalExamGrade >= 60 && finalExamGrade < 70)
            //{
            //    finalExamLetterGrade = "D";
            //    txtFinalExamPct.Text = finalExamPct.ToString("N2");
            //}

            //else
            //{
            //    finalExamLetterGrade = "F";
            //    txtFinalExamPct.Text = finalExamPct.ToString("N2");
            //}

            //If/Else statements and formulas for the Lowest Grade Dropped
            //if (grade1 <= grade2 && grade1 < grade3)
            //{
            //    lowestGradeDropped = "N/A"; //Lowest grade % dropped, displaying it as N/A (non applicable)
            //    letterGrade1 = "N/A";       //Lowest letter grade dropped, displaying it as N/A (non applicable)
            //    txtGrade1Pct.Text = lowestGradeDropped.ToString();
            //    txtFinalGrade.Text = finalGrade1SumPct.ToString();
            //}

            //else if (grade2 <= grade1 && grade2 < grade3)
            //{
            //    lowestGradeDropped = "N/A";
            //    letterGrade2 = "N/A";
            //    txtGrade2Pct.Text = lowestGradeDropped.ToString();
            //    txtFinalGrade.Text = finalGrade2SumPct.ToString();
            //}

            //else
            //{
            //    lowestGradeDropped = "N/A";
            //    letterGrade3 = "N/A";
            //    txtGrade3Pct.Text = lowestGradeDropped.ToString();
            //    txtFinalGrade.Text = finalGrade3SumPct.ToString();
            //}

            ////Focuses the cursor back to Quiz#1 after the Calculate button has been used
            //txtQuiz1.Focus();

            //Takes the variables "...letterGrade..." and displays them into textboxes 
            //txtLetterGrade1.Text = letterGrade1.ToString();
            //txtLetterGrade2.Text = letterGrade2.ToString();
            //txtLetterGrade3.Text = letterGrade3.ToString();
            //txtMidTermLetterGrade.Text = midtermLetterGrade.ToString();
            //txtFinalExamLetterGrade.Text = finalExamLetterGrade.ToString();

        }
        
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //The following clears the values entered
            lstQuizzes.Items.Clear();
            txtMidTermGrade.Clear();
            txtFinalExamGrade.Clear();
            txtFinalGrade.Clear();
            quizCounter = 0;
            //The following resets the quiz textbox and add button so they can be used anew
            this.txtQuiz.Enabled = true;
            this.btnAdd.Enabled = true;
        }
    }
}
