using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokenTest
{
    public partial class QuizKanji : Form
    {
        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        private void Passcode()
        {
            lbl_Pass.Visible = true;
        }

        public QuizKanji()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }
        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


               
                if (percentage == 100)
                {
                    MessageBox.Show("Finalizo el Quiz" + Environment.NewLine +
                                "Tu puntuacion fue de " + score + " preguntas correctas" + Environment.NewLine +
                                "Tu porcentaje total es " + percentage + " %" + Environment.NewLine +
                                "Felicidades pasaste!"

                    );
                    btn_Cont.Visible = true;
                    Passcode();
                }
                else
                {
                    MessageBox.Show("Finalizo el Quiz" + Environment.NewLine +
                                "Tu puntuacion fue de " + score + " preguntas correctas" + Environment.NewLine +
                                "Tu porcentaje total es " + percentage + " %" + Environment.NewLine +
                                "Vuelve a repetirlo para continuar!"

                    );
                    btn_Reinciar.Visible = true;
                }

            }

            questionNumber++;

            askQuestion(questionNumber);

        }


        private void askQuestion(int qnum)
        {
            switch (qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.nueve;
                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Nueve";  //correcta
                    button2.Text = "Tres";
                    button3.Text = "Ocho";
                    button4.Text = "Uno";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.uno;
                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Dos";
                    button2.Text = "Cinco";
                    button3.Text = "Uno"; //correcta
                    button4.Text = "Siete";

                    correctAnswer = 3;
                    
                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.siete;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Cero";
                    button2.Text = "Nueve";
                    button3.Text = "Tres";
                    button4.Text = "Siete";  //correcta

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.ocho;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Ocho"; //Correcta
                    button2.Text = "Diez";
                    button3.Text = "Cuatro";
                    button4.Text = "Nueve";

                    correctAnswer = 1;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.cuatro;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Uno";
                    button2.Text = "Cuatro"; //Correcta
                    button3.Text = "Cinco";
                    button4.Text = "Siete";

                    correctAnswer = 2;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.dos;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Dos"; //correcta
                    button2.Text = "Cuatro";
                    button3.Text = "Uno";
                    button4.Text = "Diez";

                    correctAnswer = 1;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.diez;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Uno";
                    button2.Text = "Cinco";
                    button3.Text = "Siete";
                    button4.Text = "Diez"; //correcta

                    correctAnswer = 4;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.tres;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Nueve";
                    button2.Text = "Tres"; //correcta
                    button3.Text = "Seis";
                    button4.Text = "Diez";

                    correctAnswer = 2;

                    break;

                case 9:

                    pictureBox1.Image = Properties.Resources.seis;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Uno";
                    button2.Text = "Dos";
                    button3.Text = "Seis"; //correcta
                    button4.Text = "Nueve";

                    correctAnswer = 3;

                    break;

                case 10:

                    pictureBox1.Image = Properties.Resources.cinco;

                    lblPreg.Text = "Cual Kanji es este?";

                    button1.Text = "Siete";
                    button2.Text = "Ocho";
                    button3.Text = "Cinco"; //correcta
                    button4.Text = "Seis";

                    correctAnswer = 3;

                    break;
            }
            
        }

        private void btn_Reinciar_Click(object sender, EventArgs e)
        {
            score = 0;
            questionNumber = 0;

            questionNumber++;

            askQuestion(questionNumber);
        }

        private void btn_Cont_Click(object sender, EventArgs e)
        {
            new DiasMeses().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
