
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
            this.BtnStart2 = new System.Windows.Forms.Button();
            this.BtnStart1 = new System.Windows.Forms.Button();
            this.LblGameModes = new System.Windows.Forms.Label();
            this.lblRealWrongAnnswer = new System.Windows.Forms.Label();
            this.lblWrongAnswer = new System.Windows.Forms.Label();
            this.lblRealCorrectAnswer = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.pctBoxFlag = new System.Windows.Forms.PictureBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBoxConitinents
            // 
            this.cmBoxConitinents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(211)))), ((int)(((byte)(200)))));
            this.cmBoxConitinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxConitinents.FormattingEnabled = true;
            this.cmBoxConitinents.Items.AddRange(new object[] {
            "All world",
            "Norh America",
            "South America",
            "Africa",
            "Asia",
            "Australia",
            "Europe"});
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
            // BtnStart2
            // 
            this.BtnStart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.BtnStart2.Location = new System.Drawing.Point(34, 457);
            this.BtnStart2.Name = "BtnStart2";
            this.BtnStart2.Size = new System.Drawing.Size(179, 63);
            this.BtnStart2.TabIndex = 7;
            this.BtnStart2.Text = "Button vs Pictures";
            this.BtnStart2.UseVisualStyleBackColor = false;
            this.BtnStart2.Click += new System.EventHandler(this.BtnStart2_Click);
            // 
            // BtnStart1
            // 
            this.BtnStart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.BtnStart1.Location = new System.Drawing.Point(34, 314);
            this.BtnStart1.Name = "BtnStart1";
            this.BtnStart1.Size = new System.Drawing.Size(179, 63);
            this.BtnStart1.TabIndex = 8;
            this.BtnStart1.Text = "Only Picture";
            this.BtnStart1.UseVisualStyleBackColor = false;
            this.BtnStart1.Click += new System.EventHandler(this.BtnStart1_Click);
            // 
            // LblGameModes
            // 
            this.LblGameModes.AutoSize = true;
            this.LblGameModes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGameModes.Location = new System.Drawing.Point(40, 244);
            this.LblGameModes.Name = "LblGameModes";
            this.LblGameModes.Size = new System.Drawing.Size(158, 29);
            this.LblGameModes.TabIndex = 9;
            this.LblGameModes.Text = "Game Modes";
            // 
            // lblRealWrongAnnswer
            // 
            this.lblRealWrongAnnswer.AutoSize = true;
            this.lblRealWrongAnnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealWrongAnnswer.ForeColor = System.Drawing.Color.Black;
            this.lblRealWrongAnnswer.Location = new System.Drawing.Point(768, 514);
            this.lblRealWrongAnnswer.Name = "lblRealWrongAnnswer";
            this.lblRealWrongAnnswer.Size = new System.Drawing.Size(23, 25);
            this.lblRealWrongAnnswer.TabIndex = 16;
            this.lblRealWrongAnnswer.Text = "0";
            // 
            // lblWrongAnswer
            // 
            this.lblWrongAnswer.AutoSize = true;
            this.lblWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWrongAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblWrongAnswer.Location = new System.Drawing.Point(599, 514);
            this.lblWrongAnswer.Name = "lblWrongAnswer";
            this.lblWrongAnswer.Size = new System.Drawing.Size(158, 25);
            this.lblWrongAnswer.TabIndex = 15;
            this.lblWrongAnswer.Text = "Wrong Answer  :";
            // 
            // lblRealCorrectAnswer
            // 
            this.lblRealCorrectAnswer.AutoSize = true;
            this.lblRealCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealCorrectAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblRealCorrectAnswer.Location = new System.Drawing.Point(476, 514);
            this.lblRealCorrectAnswer.Name = "lblRealCorrectAnswer";
            this.lblRealCorrectAnswer.Size = new System.Drawing.Size(23, 25);
            this.lblRealCorrectAnswer.TabIndex = 14;
            this.lblRealCorrectAnswer.Text = "0";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(298, 514);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(163, 25);
            this.lblCorrectAnswer.TabIndex = 13;
            this.lblCorrectAnswer.Text = "Correct Answer  :";
            // 
            // BtnB
            // 
            this.BtnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.BtnB.Location = new System.Drawing.Point(604, 372);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(189, 63);
            this.BtnB.TabIndex = 12;
            this.BtnB.Text = "button2";
            this.BtnB.UseVisualStyleBackColor = false;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.BtnA.Location = new System.Drawing.Point(310, 372);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(189, 63);
            this.BtnA.TabIndex = 11;
            this.BtnA.Text = "button1";
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // pctBoxFlag
            // 
            this.pctBoxFlag.Location = new System.Drawing.Point(390, 109);
            this.pctBoxFlag.Name = "pctBoxFlag";
            this.pctBoxFlag.Size = new System.Drawing.Size(300, 188);
            this.pctBoxFlag.TabIndex = 10;
            this.pctBoxFlag.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(473, 325);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(150, 24);
            this.checkBox.TabIndex = 17;
            this.checkBox.Text = "Show the name ";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountryName.Location = new System.Drawing.Point(467, 395);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(0, 36);
            this.lblCountryName.TabIndex = 18;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnNext.Location = new System.Drawing.Point(444, 467);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(189, 63);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(858, 616);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.lblRealWrongAnnswer);
            this.Controls.Add(this.lblWrongAnswer);
            this.Controls.Add(this.lblRealCorrectAnswer);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.pctBoxFlag);
            this.Controls.Add(this.LblGameModes);
            this.Controls.Add(this.BtnStart1);
            this.Controls.Add(this.BtnStart2);
            this.Controls.Add(this.lblContinent);
            this.Controls.Add(this.cmBoxConitinents);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flag Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxConitinents;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.Button BtnStart2;
        private System.Windows.Forms.Button BtnStart1;
        private System.Windows.Forms.Label LblGameModes;
        private System.Windows.Forms.Label lblRealWrongAnnswer;
        private System.Windows.Forms.Label lblWrongAnswer;
        private System.Windows.Forms.Label lblRealCorrectAnswer;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.PictureBox pctBoxFlag;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Button btnNext;
    }
}

