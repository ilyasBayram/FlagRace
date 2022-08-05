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
        Random randomFile = new Random();

        Random randomButtonText = new Random();

        ArrayList usedNumbers = new ArrayList();

        Flag flag = new Flag();


        #region methdos
        void RealNumberCreat()
        {
            flag.NumberReal = randomFile.Next(flag.files.Length);
        }

        void FakeNumberCreat()
        {
            flag.NumberWrong = randomFile.Next(flag.files.Length);
        }

        void Score(object sender)
        {
            if ((sender as Button).Name=="BtnA")
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

        void VisibleFlaseMember()
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
            flag.CountCorrectAnswer = 0;
            flag.CountWrongAnswer = 0;
        }

        void StartButton()
        {
            if (BtnStart.Text == "Start")
            {
                BtnStart.Text = "Exit";

                VvisibleTrueMembers();

                MakeCountZero();

                cmBoxConitinents.Enabled = false;

                flag.Continent = cmBoxConitinents.Text;

               flag.files = Directory.GetFiles(string.Format(@"C:\Users\ilyas.bayram\source\repos\FlagRace\FlagRace\Image\{0}", flag.Continent));

                GetQuestion(flag.Continent, flag.files);
            }
            else if (BtnStart.Text == "Exit")
            {
                BtnStart.Text = "Start";

                VisibleFlaseMember();

                MakeCountZero();

                lblRealCorrectAnswer.Text = "0";

                lblRealWrongAnnswer.Text = "0";

                cmBoxConitinents.Enabled = true;

                usedNumbers.Clear();
            }
        }
        
        void GetQuestion(string continent, string [] files)
        {
             
            if (usedNumbers.Count == flag.files.Length)

                usedNumbers.Clear();

            RealNumberCreat();

            FakeNumberCreat();

            while (usedNumbers.Contains(flag.NumberReal) == true)
            {
                RealNumberCreat();
            }

            while (flag.NumberReal==flag.NumberWrong)
            {
                FakeNumberCreat();
            }

            usedNumbers.Add(flag.NumberReal);

            flag.IndexReal = Path.GetFileNameWithoutExtension(flag.files[flag.NumberReal]);

            flag.IndexFake = Path.GetFileNameWithoutExtension(flag.files[flag.NumberWrong]);

            Image imgReal = Image.FromFile(flag.files[flag.NumberReal]);

            pctBoxFlag.Image = imgReal;

            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            if(randomButtonText.Next(0,2)==0)
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

            VisibleFlaseMember();

        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            Score(sender);

            GetQuestion(flag.Continent, flag.files);

            

        }

        private void BtnB_Click(object sender, EventArgs e)
        {

            Score(sender);

            GetQuestion(flag.Continent, flag.files);

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartButton();
        
        }

        #endregion

    }
}
