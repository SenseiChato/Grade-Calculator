namespace Grade_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMidTermLetterGrade = new System.Windows.Forms.TextBox();
            this.txtMidTermGrade = new System.Windows.Forms.TextBox();
            this.txtFinalExamGrade = new System.Windows.Forms.TextBox();
            this.txtFinalExamLetterGrade = new System.Windows.Forms.TextBox();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstQuizzes = new System.Windows.Forms.ListBox();
            this.txtLetterGrade1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuiz = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Quiz Marks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Midterm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final Exam:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(90, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 61);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "GRADE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(329, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "LETTER GRADE";
            // 
            // txtMidTermLetterGrade
            // 
            this.txtMidTermLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMidTermLetterGrade.Location = new System.Drawing.Point(359, 90);
            this.txtMidTermLetterGrade.Name = "txtMidTermLetterGrade";
            this.txtMidTermLetterGrade.ReadOnly = true;
            this.txtMidTermLetterGrade.Size = new System.Drawing.Size(51, 20);
            this.txtMidTermLetterGrade.TabIndex = 19;
            this.txtMidTermLetterGrade.TabStop = false;
            // 
            // txtMidTermGrade
            // 
            this.txtMidTermGrade.Location = new System.Drawing.Point(143, 169);
            this.txtMidTermGrade.Name = "txtMidTermGrade";
            this.txtMidTermGrade.Size = new System.Drawing.Size(51, 20);
            this.txtMidTermGrade.TabIndex = 4;
            // 
            // txtFinalExamGrade
            // 
            this.txtFinalExamGrade.Location = new System.Drawing.Point(143, 204);
            this.txtFinalExamGrade.Name = "txtFinalExamGrade";
            this.txtFinalExamGrade.Size = new System.Drawing.Size(51, 20);
            this.txtFinalExamGrade.TabIndex = 5;
            // 
            // txtFinalExamLetterGrade
            // 
            this.txtFinalExamLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalExamLetterGrade.Location = new System.Drawing.Point(359, 125);
            this.txtFinalExamLetterGrade.Name = "txtFinalExamLetterGrade";
            this.txtFinalExamLetterGrade.ReadOnly = true;
            this.txtFinalExamLetterGrade.Size = new System.Drawing.Size(51, 20);
            this.txtFinalExamLetterGrade.TabIndex = 22;
            this.txtFinalExamLetterGrade.TabStop = false;
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFinalGrade.Location = new System.Drawing.Point(321, 268);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.ReadOnly = true;
            this.txtFinalGrade.Size = new System.Drawing.Size(51, 20);
            this.txtFinalGrade.TabIndex = 23;
            this.txtFinalGrade.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(297, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "FINAL GRADE";
            // 
            // lstQuizzes
            // 
            this.lstQuizzes.FormattingEnabled = true;
            this.lstQuizzes.Location = new System.Drawing.Point(148, 11);
            this.lstQuizzes.Name = "lstQuizzes";
            this.lstQuizzes.Size = new System.Drawing.Size(150, 134);
            this.lstQuizzes.TabIndex = 28;
            // 
            // txtLetterGrade1
            // 
            this.txtLetterGrade1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetterGrade1.Location = new System.Drawing.Point(359, 50);
            this.txtLetterGrade1.Name = "txtLetterGrade1";
            this.txtLetterGrade1.ReadOnly = true;
            this.txtLetterGrade1.Size = new System.Drawing.Size(51, 20);
            this.txtLetterGrade1.TabIndex = 6;
            this.txtLetterGrade1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 28);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuiz
            // 
            this.txtQuiz.Location = new System.Drawing.Point(30, 82);
            this.txtQuiz.Name = "txtQuiz";
            this.txtQuiz.Size = new System.Drawing.Size(70, 20);
            this.txtQuiz.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "C&lear:";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(502, 319);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtQuiz);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstQuizzes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFinalGrade);
            this.Controls.Add(this.txtFinalExamLetterGrade);
            this.Controls.Add(this.txtFinalExamGrade);
            this.Controls.Add(this.txtMidTermLetterGrade);
            this.Controls.Add(this.txtMidTermGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLetterGrade1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMidTermLetterGrade;
        private System.Windows.Forms.TextBox txtMidTermGrade;
        private System.Windows.Forms.TextBox txtFinalExamGrade;
        private System.Windows.Forms.TextBox txtFinalExamLetterGrade;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstQuizzes;
        private System.Windows.Forms.TextBox txtLetterGrade1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuiz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
    }
}

