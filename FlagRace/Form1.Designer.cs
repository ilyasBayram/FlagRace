﻿
namespace FlagRace
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
            this.cmBoxConitinents = new System.Windows.Forms.ComboBox();
            this.lblContinent = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pctBoxFlag = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.grpBoxGame = new System.Windows.Forms.GroupBox();
            this.lblRealWrongAnnswer = new System.Windows.Forms.Label();
            this.lblWrongAnswer = new System.Windows.Forms.Label();
            this.lblRealCorrectAnswer = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).BeginInit();
            this.grpBoxGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmBoxConitinents
            // 
            this.cmBoxConitinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxConitinents.FormattingEnabled = true;
            this.cmBoxConitinents.Items.AddRange(new object[] {
            "All world",
            "Norh America",
            "South America",
            "Africa",
            "Asia",
            "Australia",
            "Europe",
            "Antartica",
            ""});
            this.cmBoxConitinents.Location = new System.Drawing.Point(18, 130);
            this.cmBoxConitinents.Name = "cmBoxConitinents";
            this.cmBoxConitinents.Size = new System.Drawing.Size(218, 28);
            this.cmBoxConitinents.TabIndex = 0;
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContinent.Location = new System.Drawing.Point(19, 83);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(211, 29);
            this.lblContinent.TabIndex = 1;
            this.lblContinent.Text = " Choose Continent";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 389);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 63);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pctBoxFlag
            // 
            this.pctBoxFlag.Location = new System.Drawing.Point(142, 87);
            this.pctBoxFlag.Name = "pctBoxFlag";
            this.pctBoxFlag.Size = new System.Drawing.Size(300, 188);
            this.pctBoxFlag.TabIndex = 2;
            this.pctBoxFlag.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(55, 350);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(189, 63);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(356, 350);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(189, 63);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // grpBoxGame
            // 
            this.grpBoxGame.Controls.Add(this.lblRealWrongAnnswer);
            this.grpBoxGame.Controls.Add(this.lblWrongAnswer);
            this.grpBoxGame.Controls.Add(this.lblRealCorrectAnswer);
            this.grpBoxGame.Controls.Add(this.lblCorrectAnswer);
            this.grpBoxGame.Controls.Add(this.btnB);
            this.grpBoxGame.Controls.Add(this.btnA);
            this.grpBoxGame.Controls.Add(this.pctBoxFlag);
            this.grpBoxGame.Location = new System.Drawing.Point(253, 39);
            this.grpBoxGame.Name = "grpBoxGame";
            this.grpBoxGame.Size = new System.Drawing.Size(581, 564);
            this.grpBoxGame.TabIndex = 6;
            this.grpBoxGame.TabStop = false;
            this.grpBoxGame.Text = "Game Area";
            // 
            // lblRealWrongAnnswer
            // 
            this.lblRealWrongAnnswer.AutoSize = true;
            this.lblRealWrongAnnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealWrongAnnswer.Location = new System.Drawing.Point(520, 492);
            this.lblRealWrongAnnswer.Name = "lblRealWrongAnnswer";
            this.lblRealWrongAnnswer.Size = new System.Drawing.Size(23, 25);
            this.lblRealWrongAnnswer.TabIndex = 8;
            this.lblRealWrongAnnswer.Text = "0";
            // 
            // lblWrongAnswer
            // 
            this.lblWrongAnswer.AutoSize = true;
            this.lblWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWrongAnswer.Location = new System.Drawing.Point(351, 492);
            this.lblWrongAnswer.Name = "lblWrongAnswer";
            this.lblWrongAnswer.Size = new System.Drawing.Size(158, 25);
            this.lblWrongAnswer.TabIndex = 7;
            this.lblWrongAnswer.Text = "Wrong Answer  :";
            // 
            // lblRealCorrectAnswer
            // 
            this.lblRealCorrectAnswer.AutoSize = true;
            this.lblRealCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealCorrectAnswer.Location = new System.Drawing.Point(228, 492);
            this.lblRealCorrectAnswer.Name = "lblRealCorrectAnswer";
            this.lblRealCorrectAnswer.Size = new System.Drawing.Size(23, 25);
            this.lblRealCorrectAnswer.TabIndex = 6;
            this.lblRealCorrectAnswer.Text = "0";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(50, 492);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(163, 25);
            this.lblCorrectAnswer.TabIndex = 5;
            this.lblCorrectAnswer.Text = "Correct Answer  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(858, 616);
            this.Controls.Add(this.grpBoxGame);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblContinent);
            this.Controls.Add(this.cmBoxConitinents);
            this.Name = "Form1";
            this.Text = "Flag Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).EndInit();
            this.grpBoxGame.ResumeLayout(false);
            this.grpBoxGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxConitinents;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pctBoxFlag;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.GroupBox grpBoxGame;
        private System.Windows.Forms.Label lblRealCorrectAnswer;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblRealWrongAnnswer;
        private System.Windows.Forms.Label lblWrongAnswer;
    }
}

