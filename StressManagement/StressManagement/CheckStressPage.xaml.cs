using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StressManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckStressPage : ContentPage
    {
        string[] cars = { "Do you experience any of the following symptoms: headaches, chest pain, muscle tension, nausea, or changes in sex drive?",
            "Do you experience fatigue and/or struggle to fall or stay asleep?",
            "Do you worry excessively and feel overwhelmed with responsibilities?",
            "Do you struggle to focus on tasks or stay motivated?" };
        int score = 0;
        int qnum = 0;

        public CheckStressPage()
        {
            InitializeComponent();
            defineLabelforbuttons();
            genrateQuestions();
        }

        public void defineLabelforbuttons()
        {
           

            btn1.Text = "Never";
            btn2.Text = "Rarely";
            btn3.Text = "Sometimes";
            btn4.Text = "Often";

            

            


        }

        void btn1_Clicked(System.Object sender, System.EventArgs e)
        {
            Button btnSender = (Button)sender;

            if(btnSender == btn1)
            {
                score +=1;
                qnum++;
            }
            else if(btnSender == btn2)
            {
                score += 2;
                qnum++;
            }
            else if(btnSender == btn3)
            {
                score += 3;
                qnum++;
            }
            else if(btnSender == btn4)
            {
                score += 4;
                qnum++;
                
            }

            genrateQuestions();



        }

        private void genrateQuestions()
        {
            if (qnum == 0)
            {
                StressQs.Text = cars[0];
            }
            else if (qnum == 1)
            {
                StressQs.Text = cars[1];
            }
            else if (qnum == 2)
            {
                StressQs.Text = cars[2];
            }
            else if (qnum == 3)
            {
                StressQs.Text = cars[3];
            }
            else
            {
                DisplayAlert("Score", "Your stress score is" + score, "Cancel");
            }
        }



    }
}