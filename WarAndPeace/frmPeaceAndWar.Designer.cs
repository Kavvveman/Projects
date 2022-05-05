using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace WarAndPeace
{
    partial class frmPeaceAndWar
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbWords = new System.Windows.Forms.ListBox();
            this.btnTop50 = new System.Windows.Forms.Button();
            this.btnSortAll = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbElapsedTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWords
            // 
            this.lbWords.FormattingEnabled = true;
            this.lbWords.Location = new System.Drawing.Point(12, 21);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(414, 251);
            this.lbWords.TabIndex = 0;
            // 
            // btnTop50
            // 
            this.btnTop50.Location = new System.Drawing.Point(336, 278);
            this.btnTop50.Name = "btnTop50";
            this.btnTop50.Size = new System.Drawing.Size(90, 34);
            this.btnTop50.TabIndex = 3;
            this.btnTop50.Text = "Top 50";
            this.btnTop50.UseVisualStyleBackColor = true;
            this.btnTop50.Click += new System.EventHandler(this.btnTop50_Click);
            // 
            // btnSortAll
            // 
            this.btnSortAll.Location = new System.Drawing.Point(245, 278);
            this.btnSortAll.Name = "btnSortAll";
            this.btnSortAll.Size = new System.Drawing.Size(85, 34);
            this.btnSortAll.TabIndex = 4;
            this.btnSortAll.Text = "Sort All";
            this.btnSortAll.UseVisualStyleBackColor = true;
            this.btnSortAll.Click += new System.EventHandler(this.btnSortAll_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(453, 21);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(81, 13);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Elapsed Time is";
            // 
            // lbElapsedTime
            // 
            this.lbElapsedTime.AutoSize = true;
            this.lbElapsedTime.Location = new System.Drawing.Point(540, 21);
            this.lbElapsedTime.Name = "lbElapsedTime";
            this.lbElapsedTime.Size = new System.Drawing.Size(10, 13);
            this.lbElapsedTime.TabIndex = 6;
            this.lbElapsedTime.Text = "-";
            // 
            // frmPeaceAndWar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 337);
            this.Controls.Add(this.lbElapsedTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnSortAll);
            this.Controls.Add(this.btnTop50);
            this.Controls.Add(this.lbWords);
            this.Name = "frmPeaceAndWar";
            this.Text = "Peace and War Text Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.Button btnTop50;
        private System.Windows.Forms.Button btnSortAll;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbElapsedTime;

        //public List<string> ExtractText()
        //{
        //    List<string> allWords = (List<string>)Regex.Split(File.ReadAllText("File.txt"), @"[\s,;:.!?-]+");
        //    return allWords;
        //}
    }

}
