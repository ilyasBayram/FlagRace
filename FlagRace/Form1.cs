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
        readonly Random randomFile = new Random();

        readonly Random randomButtonText = new Random();

        readonly ArrayList usedNumbers = new ArrayList();

        readonly Flag flag = new Flag();

        readonly GetFiles files = new GetFiles();


        #region methdos

        void RealNumberCreat()
        {
            flag.NumberReal = randomFile.Next(flag.Files.Length);
        }

        void FakeNumberCreat()
        {
            flag.NumberWrong = randomFile.Next(flag.Files.Length);
        }

        void GetContinent()
        {

            flag.Continent = cmBoxConitinents.Text;
        }

        void Score(object sender)
        {
            if ((sender as Button).Name == "BtnA")
            {
                lblRealCorrectAnswer.Text = BtnA.Text == flag.IndexReal ? Convert.ToString(flag.CountCorrectAnswer += 1) : Convert.ToString(flag.CountCorrectAnswer);

                lblRealWrongAnnswer.Text = BtnA.Text == flag.IndexFake ? Convert.ToString(flag.CountWrongAnswer += 1) : Convert.ToString(flag.CountWrongAnswer);
            }
            else if ((sender as Button).Name == "BtnB")
            {
                lblRealCorrectAnswer.Text = BtnB.Text == flag.IndexReal ? Convert.ToString(flag.CountCorrectAnswer += 1) : Convert.ToString(flag.CountCorrectAnswer);

                lblRealWrongAnnswer.Text = BtnB.Text == flag.IndexFake ? Convert.ToString(flag.CountWrongAnswer += 1) : Convert.ToString(flag.CountWrongAnswer);
            }
        }

        void PictureScore(object sender)
        {
            if ((sender as PictureBox).Name == "pctBoxGame2A")
            {
                lblRealCorrectAnswer.Text = BtnA.Text == flag.IndexReal ? Convert.ToString(flag.CountCorrectAnswer += 1) : Convert.ToString(flag.CountCorrectAnswer);

                lblRealWrongAnnswer.Text = BtnA.Text == flag.IndexFake ? Convert.ToString(flag.CountWrongAnswer += 1) : Convert.ToString(flag.CountWrongAnswer);
            }
            else if ((sender as PictureBox).Name == "pctBoxGame2B")
            {
                lblRealCorrectAnswer.Text = BtnB.Text == flag.IndexReal ? Convert.ToString(flag.CountCorrectAnswer += 1) : Convert.ToString(flag.CountCorrectAnswer);

                lblRealWrongAnnswer.Text = BtnB.Text == flag.IndexFake ? Convert.ToString(flag.CountWrongAnswer += 1) : Convert.ToString(flag.CountWrongAnswer);
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

        void VisibleFalseMember()
        {

            lblRealCorrectAnswer.Visible = false;

            lblRealWrongAnnswer.Visible = false;

            lblCorrectAnswer.Visible = false;

            lblWrongAnswer.Visible = false;

            BtnA.Visible = false;

            BtnB.Visible = false;

            pctBoxFlag.Visible = false;

            checkBox.Visible = false;

            btnNext.Visible = false;

        }

        void MakeCountZero()
        {
            flag.CountCorrectAnswer = 0;
            flag.CountWrongAnswer = 0;
        }

        void StartButton1()
        {
            if (BtnStart1.Text == "Only Picture")
            {
                BtnStart1.Text = "Exit";

                VvisibleTrueMembers();

                MakeCountZero();

                cmBoxConitinents.Enabled = false;

                BtnStart2.Enabled = false;

                BtnB.Visible = false;

                BtnA.Visible = false;

                lblRealCorrectAnswer.Visible = false;

                lblRealWrongAnnswer.Visible = false;

                lblCorrectAnswer.Visible = false;

                lblWrongAnswer.Visible = false;

                checkBox.Visible = true;

                btnNext.Visible = true;

                GetContinent();

                files.GetPicture(flag);

                GetQuestion();

            }
            else if (BtnStart1.Text == "Exit")
            {
                BtnStart1.Text = "Only Picture";

                VisibleFalseMember();

                MakeCountZero();

                BtnStart2.Enabled = true;

                lblRealCorrectAnswer.Text = "0";

                lblRealWrongAnnswer.Text = "0";

                cmBoxConitinents.Enabled = true;

                usedNumbers.Clear();
            }
        }

        void StartButton2()
        {
            if (BtnStart2.Text == "Button vs Pictures")
            {
                BtnStart2.Text = "Exit";

                VvisibleTrueMembers();

                MakeCountZero();

                cmBoxConitinents.Enabled = false;

                BtnStart1.Enabled = false;

                lblRealCorrectAnswer.Visible = true;

                lblRealWrongAnnswer.Visible = true;

                lblCorrectAnswer.Visible = true;

                lblWrongAnswer.Visible = true;


                GetContinent();

                files.GetPicture(flag);

                GetQuestion();

            }
            else if (BtnStart2.Text == "Exit")
            {
                BtnStart2.Text = "Button vs Pictures";

                VisibleFalseMember();

                MakeCountZero();

                BtnStart1.Enabled = true;

                lblRealCorrectAnswer.Text = "0";

                lblRealWrongAnnswer.Text = "0";

                cmBoxConitinents.Enabled = true;

                usedNumbers.Clear();
            }

        }

        void GetQuestion()
        {

            if (usedNumbers.Count == flag.Files.Length)

                usedNumbers.Clear();

            RealNumberCreat();

            FakeNumberCreat();

            while (usedNumbers.Contains(flag.NumberReal) == true)
            {
                RealNumberCreat();
            }

            while (flag.NumberReal == flag.NumberWrong)
            {
                FakeNumberCreat();
            }

            usedNumbers.Add(flag.NumberReal);

            flag.IndexReal = Path.GetFileNameWithoutExtension(flag.Files[flag.NumberReal]);

            flag.IndexFake = Path.GetFileNameWithoutExtension(flag.Files[flag.NumberWrong]);

            Image imgReal = Image.FromFile(flag.Files[flag.NumberReal]);

            pctBoxFlag.Image = imgReal;

            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            if (randomButtonText.Next(0, 2) == 0)
            {
                BtnA.Text = flag.IndexReal;
                BtnB.Text = flag.IndexFake;
            }
            else
            {
                BtnA.Text = flag.IndexFake;
                BtnB.Text = flag.IndexReal;
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

            VisibleFalseMember();

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

        private void BtnStart1_Click(object sender, EventArgs e)
        {

            StartButton1();


        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            StartButton2();
        }


        #endregion

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox.Checked)
            {
                flag.IndexReal = Path.GetFileNameWithoutExtension(flag.Files[flag.NumberReal]);

                lblCountryName.Visible = true;

                lblCountryName.Text = flag.IndexReal;
            }
            else
            {
                lblCountryName.Visible = false;
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GetQuestion();

            if (checkBox.Checked)
            {
                checkBox.Checked = false;
            }
        }
       
    }
}
