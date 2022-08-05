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

  
        #region variables

        int numberReal, numberWrong, countCorrectAnswer, countWrongAnswer;


        string continent, indexReal, indexFake;


        string[] files;

        #endregion

        #region methdos
        void realNumberCreat()
        {
            numberReal = randomFile.Next(files.Length);
        }

        void fakeNumberCreat()
        {
            numberWrong = randomFile.Next(files.Length);
        }

        void score(object sender)
        {
            if ((sender as Button).Name=="btnA")
            {
                lblRealCorrectAnswer.Text = btnA.Text == indexReal ? Convert.ToString(countCorrectAnswer += 1) : Convert.ToString(countCorrectAnswer);

                lblRealWrongAnnswer.Text = btnA.Text == indexFake ? Convert.ToString(countWrongAnswer += 1) : Convert.ToString(countWrongAnswer);
            }
            else if ((sender as Button).Name == "btnB")
            {
                lblRealCorrectAnswer.Text = btnB.Text == indexReal ? Convert.ToString(countCorrectAnswer += 1) : Convert.ToString(countCorrectAnswer);

                lblRealWrongAnnswer.Text = btnB.Text == indexFake ? Convert.ToString(countWrongAnswer += 1) : Convert.ToString(countWrongAnswer);
            }
        }

        void visibleTrueMembers()
        {
            lblRealCorrectAnswer.Visible = true;

            lblRealWrongAnnswer.Visible = true;

            lblCorrectAnswer.Visible = true;

            lblWrongAnswer.Visible = true;

            btnA.Visible = true;

            btnB.Visible = true;

            pctBoxFlag.Visible = true;
        }

        void visibleFlaseMember()
        {

            lblRealCorrectAnswer.Visible = false;

            lblRealWrongAnnswer.Visible = false;

            lblCorrectAnswer.Visible = false;

            lblWrongAnswer.Visible = false;

            btnA.Visible = false;

            btnB.Visible = false;

            pctBoxFlag.Visible = false;
        }

        void makeCountZero()
        {
            countCorrectAnswer = 0;
            countWrongAnswer = 0;
        }

        void startButton()
        {
            if (btnStart.Text == "Start")
            {
                btnStart.Text = "Exit";

                visibleTrueMembers();

                makeCountZero();

                cmBoxConitinents.Enabled = false;

                continent = cmBoxConitinents.Text;

                files = Directory.GetFiles(string.Format(@"C:\Users\ilyas.bayram\source\repos\FlagRace\FlagRace\Image\{0}", continent));

                getQuestion(continent, files);
            }
            else if (btnStart.Text == "Exit")
            {
                btnStart.Text = "Start";

                visibleFlaseMember();

                makeCountZero();

                lblRealCorrectAnswer.Text = "0";

                lblRealWrongAnnswer.Text = "0";

                cmBoxConitinents.Enabled = true;

                usedNumbers.Clear();
            }
        }
        
        void getQuestion(string continent, string [] files)
        {
             
            if (usedNumbers.Count == files.Length)

                usedNumbers.Clear();

            realNumberCreat();

            fakeNumberCreat();

            while (usedNumbers.Contains(numberReal) == true)
            {
                realNumberCreat();
            }

            while (numberReal==numberWrong)
            {
                fakeNumberCreat();
            }

            usedNumbers.Add(numberReal);

            indexReal = Path.GetFileNameWithoutExtension(files[numberReal]);

            indexFake = Path.GetFileNameWithoutExtension(files[numberWrong]);

            Image imgReal = Image.FromFile(files[numberReal]);

            pctBoxFlag.Image = imgReal;

            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            if(randomButtonText.Next(0,2)==0)
            {
                btnA.Text = indexReal;
                btnB.Text = indexFake;
            }
            else
            {
                btnA.Text = indexFake;
                btnB.Text = indexReal;
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

            visibleFlaseMember();

        }

        private void btnA_Click(object sender, EventArgs e)
        {

            score(sender);

            getQuestion(continent, files);

            

        }

        private void btnB_Click(object sender, EventArgs e)
        {

            score(sender);

            getQuestion(continent, files);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startButton();
        
        }

        #endregion

    }
}
