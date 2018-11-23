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
        string[] quizNumber = { "Quiz 1", "Quiz 2", "Quiz 3"/*, "Quiz 4", "Quiz 5", "Quiz 6", "Quiz 7", "Quiz 8", "Quiz 9", "Quiz 10"*/};
        double[] qMarks = new double[MAX];
        int quizCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //The following will add quizzes into the list box
            double scores;
            double[] subtotal = new double[MAX];

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

        //// TWO PARAMS: an array of numbers of type double (same as qMarks)
        //// and an int value indicating the number of elements in the qMarks array

        //public double FindLowest(double[] arr, int elements)
        //{
        //    // set lowest to a potentially high value in the array
        //    double lowest = 100.00;

        //    for (int i = 0; i < elements; i++)
        //    {
        //        // check if current element is lower than lowest
        //        if (arr[i] < lowest)
        //        {
        //            lowest = arr[i];
        //        }
        //    }
        //    // the method returns the lowest value in the array
        //    return lowest;
        //}

        // TWO PARAMS: an array of numbers of type double (same as qMarks)
        // and an int value indicating the number of elements in the qMarks array

        public double FindLowest(double[] qMarks, int elements)
        {
            // set lowest to a potentially high value in the array
            double lowest = 100.00;

            for (int i = 0; i < elements; i++)
            {
                // check if current element is lower than lowest
                if (qMarks[i] < lowest)
                {
                    lowest = qMarks[i];
                }
            }
            // the method returns the lowest value in the array
            return lowest;
        }

        //The following method is used to make the math to attain the percentage of the quizzes.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    double quizSum;
                    double midtermPct;
                    //double finalExamPct;
                    double midtermGrade;
                    double finalExamGrade;

                    double grade1;
                    string letterGrade1;

                    midtermGrade = Convert.ToDouble(txtMidTermGrade.Text);
                    finalExamGrade = Convert.ToDouble(txtFinalExamGrade.Text);

                    quizSum = 0;

                    for (int i = 0; i <= 9; i++)
                    {
                        quizSum = quizSum + qMarks[i];
                    }

                    quizSum = quizSum * 3.3333 / 100 / 10;

                    //midtermPct = (double)midtermGrade * 30 / 100;
                    //finalExamPct = (double)finalExamGrade * 40 / 100;

                    txtFinalGrade.Text = quizSum.ToString("p");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                           ex.GetType().ToString() + "\n" +
                           ex.StackTrace, "Exception");
            }
            // Call FindLowest with PARAMS: double[] qMarks, const int MAX to find lowest grade in quiz marks array. 
            double lowest_quiz_mark = FindLowest(qMarks, MAX);                    

        }

        public bool IsValidData()
        {
            return
                //IsPresent(txtQuiz, "Quiz Mark") &&
                IsPresent(txtMidTermGrade, "Midterm Grade") &&
                IsDecimal(txtMidTermGrade, "Midterm Grade") &&
                IsWithinRange(txtMidTermGrade, "Midterm Grade", 0, 100) &&

                IsPresent(txtFinalExamGrade, "Final Exam Grade") &&
                IsDecimal(txtFinalExamGrade, "Final Exam Grade") &&
                IsWithinRange(txtFinalExamGrade, "Final Exam Grade", 0, 100);
                
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if(number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
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
