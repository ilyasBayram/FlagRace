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


        int numberReal;

        int numberWrong;

        int countCorrectAnswer;

        int countTotalQuestion;

        string continent;

        string indexReal;

        string indexFake;

        string[] files;


        void realNumberCreat()
        {
            numberReal = randomFile.Next(files.Length);
        }

        void score()
        {
            ;
            if ((sender as Button).Text==)
            {

            }
        }

        void fakeNumberCreat()
        {
            numberWrong = randomFile.Next(files.Length);
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBoxConitinents.Text = "Europe";

            btnA.Visible = false;

            btnB.Visible = false;

        }

        private void btnA_Click(object sender, EventArgs e)
        {

            lblRealCorrectAnswer.Text = btnA.Text == indexReal ? Convert.ToString(countCorrectAnswer += 1) : Convert.ToString(countCorrectAnswer);

            getQuestion(continent, files);

            

        }

        private void btnB_Click(object sender, EventArgs e)
        {

            lblRealCorrectAnswer.Text = btnB.Text == indexReal ? Convert.ToString(countCorrectAnswer += 1) : Convert.ToString(countCorrectAnswer);

            getQuestion(continent, files);

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text =="Start")
            {
                btnStart.Text = "Exit";

                cmBoxConitinents.Enabled = false;

                btnA.Visible = true;

                btnB.Visible = true;

                pctBoxFlag.Visible = true;

                continent = cmBoxConitinents.Text;

                files = Directory.GetFiles(string.Format(@"C:\Users\ilyas.bayram\source\repos\FlagRace\FlagRace\Image\{0}", continent));

                getQuestion(continent, files);
            }
            else if(btnStart.Text == "Exit")
            {
                btnStart.Text = "Start";

                cmBoxConitinents.Enabled = true;

                btnA.Visible = false;

                btnB.Visible = false;

                pctBoxFlag.Visible = false;

                usedNumbers.Clear();
            }
            

           
        }

    
    }
}
