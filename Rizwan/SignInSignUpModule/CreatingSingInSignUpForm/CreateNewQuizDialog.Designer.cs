﻿namespace CreatingSingInSignUpForm
{
    partial class CreateNewQuizDialog
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
            this.comboBoxSubjectList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuizName = new System.Windows.Forms.TextBox();
            this.buttonCreateQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSubjectList
            // 
            this.comboBoxSubjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjectList.FormattingEnabled = true;
            this.comboBoxSubjectList.Location = new System.Drawing.Point(233, 59);
            this.comboBoxSubjectList.Name = "comboBoxSubjectList";
            this.comboBoxSubjectList.Size = new System.Drawing.Size(181, 32);
            this.comboBoxSubjectList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Subject :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quiz Name :";
            // 
            // textBoxQuizName
            // 
            this.textBoxQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuizName.Location = new System.Drawing.Point(233, 129);
            this.textBoxQuizName.Name = "textBoxQuizName";
            this.textBoxQuizName.Size = new System.Drawing.Size(181, 29);
            this.textBoxQuizName.TabIndex = 3;
            // 
            // buttonCreateQuiz
            // 
            this.buttonCreateQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateQuiz.Location = new System.Drawing.Point(467, 74);
            this.buttonCreateQuiz.Name = "buttonCreateQuiz";
            this.buttonCreateQuiz.Size = new System.Drawing.Size(149, 69);
            this.buttonCreateQuiz.TabIndex = 4;
            this.buttonCreateQuiz.Text = "Creat Quiz";
            this.buttonCreateQuiz.UseVisualStyleBackColor = true;
            this.buttonCreateQuiz.Click += new System.EventHandler(this.buttonCreateQuiz_Click);
            // 
            // CreateNewQuizDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 217);
            this.Controls.Add(this.buttonCreateQuiz);
            this.Controls.Add(this.textBoxQuizName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSubjectList);
            this.Name = "CreateNewQuizDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateNewQuizDialog";
            this.Load += new System.EventHandler(this.CreateNewQuizDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSubjectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuizName;
        private System.Windows.Forms.Button buttonCreateQuiz;
    }
}