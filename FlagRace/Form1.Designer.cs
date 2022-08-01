
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
            this.pctBoxFlag = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).BeginInit();
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
            this.cmBoxConitinents.Location = new System.Drawing.Point(206, 62);
            this.cmBoxConitinents.Name = "cmBoxConitinents";
            this.cmBoxConitinents.Size = new System.Drawing.Size(396, 28);
            this.cmBoxConitinents.TabIndex = 0;
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContinent.Location = new System.Drawing.Point(15, 62);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(127, 29);
            this.lblContinent.TabIndex = 1;
            this.lblContinent.Text = "Continent :";
            // 
            // pctBoxFlag
            // 
            this.pctBoxFlag.Location = new System.Drawing.Point(263, 183);
            this.pctBoxFlag.Name = "pctBoxFlag";
            this.pctBoxFlag.Size = new System.Drawing.Size(300, 188);
            this.pctBoxFlag.TabIndex = 2;
            this.pctBoxFlag.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(168, 457);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(189, 54);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(460, 457);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(189, 54);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 620);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pctBoxFlag);
            this.Controls.Add(this.lblContinent);
            this.Controls.Add(this.cmBoxConitinents);
            this.Name = "Form1";
            this.Text = "Flag Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxConitinents;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.PictureBox pctBoxFlag;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
    }
}

