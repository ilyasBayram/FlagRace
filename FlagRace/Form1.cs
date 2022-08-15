using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace FlagRace
{
    public partial class Form1 : Form
    {
        readonly Random RandomFile = new Random();

        readonly Random RandomButtonText = new Random();

        readonly ArrayList UsedNumbers = new ArrayList();

        readonly Flag Flag = new Flag();

        GetFiles Files = new GetFiles();


        #region methdos

        void RealNumberCreat()
        {
            Flag.NumberReal = RandomFile.Next(Flag.Files.Length);
        }

        void FakeNumberCreat()
        {
            Flag.NumberWrong = RandomFile.Next(Flag.Files.Length);
        }

        void GetContinent()
        {

            Flag.Continent = cmBoxConitinents.Text;
        }

        void Score(object sender)
        {
            if ((sender as Button).Name=="BtnA")
            {
                lblRealCorrectAnswer.Text = BtnA.Text == Flag.IndexReal ? Convert.ToString(Flag.CountCorrectAnswer += 1) : Convert.ToString(Flag.CountCorrectAnswer);

                lblRealWrongAnnswer.Text = BtnA.Text == Flag.IndexFake ? Convert.ToString(Flag.CountWrongAnswer += 1) : Convert.ToString(Flag.CountWrongAnswer);
            }
            else if ((sender as Button).Name == "BtnB")
            {
                lblRealCorrectAnswer.Text = BtnB.Text == Flag.IndexReal ? Convert.ToString(Flag.CountCorrectAnswer += 1) : Convert.ToString(Flag.CountCorrectAnswer);

                lblRealWrongAnnswer.Text = BtnB.Text == Flag.IndexFake ? Convert.ToString(Flag.CountWrongAnswer += 1) : Convert.ToString(Flag.CountWrongAnswer);
            }
        }

        void VvisibleTrueMembers()
        {
            lblRealCorrectAnswer.Visible = true;

            lblRealWrongAnnswer.Visible = true;

            lblCorrectAnswer.Visible = true;

            lblWrongAnswer.Visible = true;

            BtnA.Visible = true;

            BtnB.Visible = true;

            pctBoxFlag.Visible = true;
        }

        void VisibleFalseeMember()
        {

            lblRealCorrectAnswer.Visible = false;

            lblRealWrongAnnswer.Visible = false;

            lblCorrectAnswer.Visible = false;

            lblWrongAnswer.Visible = false;

            BtnA.Visible = false;

            BtnB.Visible = false;

            pctBoxFlag.Visible = false;
        }

        void MakeCountZero()
        {
            Flag.CountCorrectAnswer = 0;
            Flag.CountWrongAnswer = 0;
        }

        void StartButton()
        {
            if (BtnStart.Text == "Start")
            {
                BtnStart.Text = "Exit";

                VvisibleTrueMembers();

                MakeCountZero();

                cmBoxConitinents.Enabled = false;

                GetContinent();

                Files.GetPicture(Flag);

                GetQuestion();
            }
            else if (BtnStart.Text == "Exit")
            {
                BtnStart.Text = "Start";

                VisibleFalseeMember();

                MakeCountZero();

                lblRealCorrectAnswer.Text = "0";

                lblRealWrongAnnswer.Text = "0";

                cmBoxConitinents.Enabled = true;

                UsedNumbers.Clear();
            }
        }
        
        void GetQuestion()
        {
             
            if (UsedNumbers.Count == Flag.Files.Length)

                UsedNumbers.Clear();

            RealNumberCreat();

            FakeNumberCreat();

            while (UsedNumbers.Contains(Flag.NumberReal) == true)
            {
                RealNumberCreat();
            }

            while (Flag.NumberReal==Flag.NumberWrong)
            {
                FakeNumberCreat();
            }

            UsedNumbers.Add(Flag.NumberReal);

            Flag.IndexReal = Path.GetFileNameWithoutExtension(Flag.Files[Flag.NumberReal]);

            Flag.IndexFake = Path.GetFileNameWithoutExtension(Flag.Files[Flag.NumberWrong]);

            Image imgReal = Image.FromFile(Flag.Files[Flag.NumberReal]);

            pctBoxFlag.Image = imgReal;

            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            if(RandomButtonText.Next(0,2)==0)
            {
                BtnA.Text = Flag.IndexReal;
                BtnB.Text = Flag.IndexFake;
            }
            else
            {
                BtnA.Text = Flag.IndexFake;
                BtnB.Text = Flag.IndexReal;
            }
           

        }

        
        
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region main

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBoxConitinents.Text = "Europe";

            VisibleFalseeMember();

        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            Score(sender);

            GetQuestion();

            

        }

        private void BtnB_Click(object sender, EventArgs e)
        {

            Score(sender);

            GetQuestion();

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartButton();
        }

        #endregion

    }
}
