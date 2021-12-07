using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizHistoire : ContentPage
    {
        private int score = 0;
        private int nbreQuestion = 0;
        private int totalQuestion = 10;
        int pourcentage;
        public QuizHistoire()
        {
            InitializeComponent();
        }
        /* Méthode pour démarer le quiz avec le minuteur */
        void StartTimer_Clicked(object sender, System.EventArgs e)
        {
            /*Pour gérer le minuteur*/
            var minutes = 1;
            var seconds = 30;

            BlocImage01.IsVisible = true;
            BlocQuestion01.IsVisible = true;
            Proposition0101.IsVisible = true;
            Proposition0102.IsVisible = true;
            Proposition0103.IsVisible = true;
            Proposition0104.IsVisible = true;
            ReponseQuestion01.IsVisible = true;
            BlocValidationBas01.IsVisible = true;

            LancerQuiz.IsVisible = false;
            /*Fonction native qui gère le minuteur basé sur Xamarin*/
            Device.StartTimer(TimeSpan.FromSeconds(1), () => {

                if (seconds > 0)
                {
                    seconds--;
                    /* Affichage du temps.*/
                    Timer.Text = $"{minutes}:{seconds}";
                }
                else
                {
                    if (minutes > 0)
                    {
                        // Reset pour les secondes.
                        seconds = 60;

                        //Décompte des minutes.
                        minutes--;

                        /* Affichage du temps remis a neuf lors du changement de minutes*/
                        Timer.Text = $"{minutes}:{seconds}";
                    }
                    else
                    {
                        pourcentage = (int)Math.Round((double)(score * 100) / totalQuestion);
                        BlocImage01.IsVisible = false;
                        BlocQuestion01.IsVisible = false;
                        Proposition0101.IsVisible = false;
                        Proposition0102.IsVisible = false;
                        Proposition0103.IsVisible = false;
                        Proposition0104.IsVisible = false;
                        ReponseQuestion01.IsVisible = false;
                        BlocValidationBas01.IsVisible = false;
                        BlocSuivantBas01.IsVisible = false;

                        BlocImage02.IsVisible = false;
                        BlocQuestion02.IsVisible = false;
                        Proposition0201.IsVisible = false;
                        Proposition0202.IsVisible = false;
                        Proposition0203.IsVisible = false;
                        Proposition0204.IsVisible = false;
                        ReponseQuestion02.IsVisible = false;
                        BlocValidationBas02.IsVisible = false;
                        BlocSuivantBas02.IsVisible = false;

                        BlocImage03.IsVisible = false;
                        BlocQuestion03.IsVisible = false;
                        Proposition0301.IsVisible = false;
                        Proposition0302.IsVisible = false;
                        Proposition0303.IsVisible = false;
                        Proposition0304.IsVisible = false;
                        ReponseQuestion03.IsVisible = false;
                        BlocValidationBas03.IsVisible = false;
                        BlocSuivantBas03.IsVisible = false;

                        BlocImage04.IsVisible = false;
                        BlocQuestion04.IsVisible = false;
                        Proposition0401.IsVisible = false;
                        Proposition0402.IsVisible = false;
                        Proposition0403.IsVisible = false;
                        Proposition0404.IsVisible = false;
                        ReponseQuestion04.IsVisible = false;
                        BlocValidationBas04.IsVisible = false;
                        BlocSuivantBas04.IsVisible = false;

                        BlocImage05.IsVisible = false;
                        BlocQuestion05.IsVisible = false;
                        Proposition0501.IsVisible = false;
                        Proposition0502.IsVisible = false;
                        Proposition0503.IsVisible = false;
                        Proposition0504.IsVisible = false;
                        ReponseQuestion05.IsVisible = false;
                        BlocValidationBas05.IsVisible = false;
                        BlocSuivantBas05.IsVisible = false;

                        BlocImage06.IsVisible = false;
                        BlocQuestion06.IsVisible = false;
                        Proposition0601.IsVisible = false;
                        Proposition0602.IsVisible = false;
                        Proposition0603.IsVisible = false;
                        Proposition0604.IsVisible = false;
                        ReponseQuestion06.IsVisible = false;
                        BlocValidationBas06.IsVisible = false;
                        BlocSuivantBas06.IsVisible = false;

                        BlocImage07.IsVisible = false;
                        BlocQuestion07.IsVisible = false;
                        Proposition0701.IsVisible = false;
                        Proposition0702.IsVisible = false;
                        Proposition0703.IsVisible = false;
                        Proposition0704.IsVisible = false;
                        ReponseQuestion07.IsVisible = false;
                        BlocValidationBas07.IsVisible = false;
                        BlocSuivantBas07.IsVisible = false;

                        BlocImage08.IsVisible = false;
                        BlocQuestion08.IsVisible = false;
                        Proposition0801.IsVisible = false;
                        Proposition0802.IsVisible = false;
                        Proposition0803.IsVisible = false;
                        Proposition0804.IsVisible = false;
                        ReponseQuestion08.IsVisible = false;
                        BlocValidationBas08.IsVisible = false;
                        BlocSuivantBas08.IsVisible = false;

                        BlocImage09.IsVisible = false;
                        BlocQuestion09.IsVisible = false;
                        Proposition0901.IsVisible = false;
                        Proposition0902.IsVisible = false;
                        Proposition0903.IsVisible = false;
                        Proposition0904.IsVisible = false;
                        ReponseQuestion09.IsVisible = false;
                        BlocValidationBas09.IsVisible = false;
                        BlocSuivantBas09.IsVisible = false;

                        BlocImage10.IsVisible = false;
                        BlocQuestion10.IsVisible = false;
                        Proposition1001.IsVisible = false;
                        Proposition1002.IsVisible = false;
                        Proposition1003.IsVisible = false;
                        Proposition1004.IsVisible = false;
                        ReponseQuestion10.IsVisible = false;
                        BlocValidationBas10.IsVisible = false;
                        BlocSuivantBas10.IsVisible = false;

                        BlocFinQuiz.IsVisible = true;
                        TextFinQuiz.FontSize = 25;
                        TextFinQuiz.Text = "Temps écoulé !" + Environment.NewLine + "Vous avez répondu à " + nbreQuestion + " questions sur " + totalQuestion + "." + Environment.NewLine + "Vous avez " + pourcentage + "% de réussite !" + Environment.NewLine + "Vous avez " + score + " bonnes réponses sur " + totalQuestion + " !";

                        // On renvoie false une fois à 0 pour stoper.
                        return false;
                    }
                }
                return true; // True = Repeat again, False = Stop the timer
            });
        }
        /*--------Reponse 01--------*/
        public void Reponse0101Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion01.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0102Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion01.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0103Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion01.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0104Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion01.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked(object sender, EventArgs e)
        {
            if (ReponseQuestion01.Text == "Vous avez répondu : Saul")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, David est devenu roi d'Israël à la mort de Saul." + Environment.NewLine + "2Samuel 5.4";
                TextFinQuiz.Text = "Bravo !";
                BlocImage01.IsVisible = false;
                BlocQuestion01.IsVisible = false;
                Proposition0101.IsVisible = false;
                Proposition0102.IsVisible = false;
                Proposition0103.IsVisible = false;
                Proposition0104.IsVisible = false;
                ReponseQuestion01.IsVisible = false;
                BlocValidationBas01.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas01.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, David est devenu roi d'Israël à la mort de Saul." + Environment.NewLine + "2Samuel 5.4";
                TextFinQuiz.Text = "Dommage !";
                BlocImage01.IsVisible = false;
                BlocQuestion01.IsVisible = false;
                Proposition0101.IsVisible = false;
                Proposition0102.IsVisible = false;
                Proposition0103.IsVisible = false;
                Proposition0104.IsVisible = false;
                ReponseQuestion01.IsVisible = false;
                BlocValidationBas01.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas01.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked01(object sender, EventArgs e)
        {
            BlocImage02.IsVisible = true;
            BlocQuestion02.IsVisible = true;
            Proposition0201.IsVisible = true;
            Proposition0202.IsVisible = true;
            Proposition0203.IsVisible = true;
            Proposition0204.IsVisible = true;
            ReponseQuestion02.IsVisible = true;
            BlocValidationBas02.IsVisible = true;
            BlocSuivantBas01.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas02.IsVisible = false;
        }
        /*--------Reponse 02--------*/
        public void Reponse0201Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion02.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0202Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion02.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0203Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion02.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0204Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion02.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked02(object sender, EventArgs e)
        {
            if (ReponseQuestion02.Text == "Vous avez répondu : Jean le Baptiste")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Jésus s'est fait baptiser par Jean le Baptiste." + Environment.NewLine + "Marc 1.9";
                TextFinQuiz.Text = "bravo !";
                BlocImage02.IsVisible = false;
                BlocQuestion02.IsVisible = false;
                Proposition0201.IsVisible = false;
                Proposition0202.IsVisible = false;
                Proposition0203.IsVisible = false;
                Proposition0204.IsVisible = false;
                ReponseQuestion02.IsVisible = false;
                BlocValidationBas02.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas02.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Jésus s'est fait baptiser par Jean le Baptiste." + Environment.NewLine + "Marc 1.9";
                TextFinQuiz.Text = "Dommage !";
                BlocImage02.IsVisible = false;
                BlocQuestion02.IsVisible = false;
                Proposition0201.IsVisible = false;
                Proposition0202.IsVisible = false;
                Proposition0203.IsVisible = false;
                Proposition0204.IsVisible = false;
                ReponseQuestion02.IsVisible = false;
                BlocValidationBas02.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas02.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked02(object sender, EventArgs e)
        {
            BlocImage03.IsVisible = true;
            BlocQuestion03.IsVisible = true;
            Proposition0301.IsVisible = true;
            Proposition0302.IsVisible = true;
            Proposition0303.IsVisible = true;
            Proposition0304.IsVisible = true;
            ReponseQuestion03.IsVisible = true;
            BlocValidationBas03.IsVisible = true;
            BlocSuivantBas02.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas03.IsVisible = false;
        }
        /*--------Reponse 03--------*/
        public void Reponse0301Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion03.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0302Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion03.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0303Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion03.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0304Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion03.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked03(object sender, EventArgs e)
        {
            if (ReponseQuestion03.Text == "Vous avez répondu : Les babyloniens")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, ce sont les babyloniens qui ont envoyé Israël en exil après la destruction de Jérusalem." + Environment.NewLine + "1Chroniques 9.1 & 2Chroniques 36.20";
                TextFinQuiz.Text = "bravo !";
                BlocImage03.IsVisible = false;
                BlocQuestion03.IsVisible = false;
                Proposition0301.IsVisible = false;
                Proposition0302.IsVisible = false;
                Proposition0303.IsVisible = false;
                Proposition0304.IsVisible = false;
                ReponseQuestion03.IsVisible = false;
                BlocValidationBas03.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas03.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, ce sont les babyloniens qui ont envoyé Israël en exil après la destruction de Jérusalem." + Environment.NewLine + "1Chroniques 9.1 & 2Chroniques 36.20";
                TextFinQuiz.Text = "Dommage !";
                BlocImage03.IsVisible = false;
                BlocQuestion03.IsVisible = false;
                Proposition0301.IsVisible = false;
                Proposition0302.IsVisible = false;
                Proposition0303.IsVisible = false;
                Proposition0304.IsVisible = false;
                ReponseQuestion03.IsVisible = false;
                BlocValidationBas03.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas03.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked03(object sender, EventArgs e)
        {
            BlocImage04.IsVisible = true;
            BlocQuestion04.IsVisible = true;
            Proposition0401.IsVisible = true;
            Proposition0402.IsVisible = true;
            Proposition0403.IsVisible = true;
            Proposition0404.IsVisible = true;
            ReponseQuestion04.IsVisible = true;
            BlocValidationBas04.IsVisible = true;
            BlocSuivantBas03.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas04.IsVisible = false;
        }
        /*--------Reponse 04--------*/
        public void Reponse0401Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion04.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0402Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion04.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0403Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion04.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0404Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion04.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked04(object sender, EventArgs e)
        {
            if (ReponseQuestion04.Text == "Vous avez répondu : 365 ans")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Hénoch vécu pendant 365 ans avant d'être enlevé par Dieu." + Environment.NewLine + "Genèse 5.23";
                TextFinQuiz.Text = "bravo !";
                BlocImage04.IsVisible = false;
                BlocQuestion04.IsVisible = false;
                Proposition0401.IsVisible = false;
                Proposition0402.IsVisible = false;
                Proposition0403.IsVisible = false;
                Proposition0404.IsVisible = false;
                ReponseQuestion04.IsVisible = false;
                BlocValidationBas04.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas04.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Hénoch vécu pendant 365 ans avant d'être enlevé par Dieu." + Environment.NewLine + "Genèse 5.23";
                TextFinQuiz.Text = "Dommage !";
                BlocImage04.IsVisible = false;
                BlocQuestion04.IsVisible = false;
                Proposition0401.IsVisible = false;
                Proposition0402.IsVisible = false;
                Proposition0403.IsVisible = false;
                Proposition0404.IsVisible = false;
                ReponseQuestion04.IsVisible = false;
                BlocValidationBas04.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas04.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked04(object sender, EventArgs e)
        {
            BlocImage05.IsVisible = true;
            BlocQuestion05.IsVisible = true;
            Proposition0501.IsVisible = true;
            Proposition0502.IsVisible = true;
            Proposition0503.IsVisible = true;
            Proposition0504.IsVisible = true;
            ReponseQuestion05.IsVisible = true;
            BlocValidationBas05.IsVisible = true;
            BlocSuivantBas03.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas04.IsVisible = false;
        }
        /*--------Reponse 05--------*/
        public void Reponse0501Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion05.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0502Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion05.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0503Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion05.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0504Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion05.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked05(object sender, EventArgs e)
        {
            if (ReponseQuestion05.Text == "Vous avez répondu : Damas")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Paul se fit baptiser à Damas par Ananias." + Environment.NewLine + "Actes 9.18";
                TextFinQuiz.Text = "bravo !";
                BlocImage05.IsVisible = false;
                BlocQuestion05.IsVisible = false;
                Proposition0501.IsVisible = false;
                Proposition0502.IsVisible = false;
                Proposition0503.IsVisible = false;
                Proposition0504.IsVisible = false;
                ReponseQuestion05.IsVisible = false;
                BlocValidationBas05.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas05.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Paul se fit baptiser à Damas par Ananias." + Environment.NewLine + "Actes 9.18";
                TextFinQuiz.Text = "Dommage !";
                BlocImage05.IsVisible = false;
                BlocQuestion05.IsVisible = false;
                Proposition0501.IsVisible = false;
                Proposition0502.IsVisible = false;
                Proposition0503.IsVisible = false;
                Proposition0504.IsVisible = false;
                ReponseQuestion05.IsVisible = false;
                BlocValidationBas05.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas05.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked05(object sender, EventArgs e)
        {
            BlocImage06.IsVisible = true;
            BlocQuestion06.IsVisible = true;
            Proposition0601.IsVisible = true;
            Proposition0602.IsVisible = true;
            Proposition0603.IsVisible = true;
            Proposition0604.IsVisible = true;
            ReponseQuestion06.IsVisible = true;
            BlocValidationBas06.IsVisible = true;
            BlocSuivantBas05.IsVisible = false;
            BlocSuivantBas04.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
        }
        /*--------Reponse 06--------*/
        public void Reponse0601Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion06.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0602Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion06.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0603Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion06.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0604Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion06.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked06(object sender, EventArgs e)
        {
            if (ReponseQuestion06.Text == "Vous avez répondu : Jéthro")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, c'est Jéthro le beau-père de Moïse, prêtre de Madian qui reconnut la grandeur de l'Eternel." + Environment.NewLine + "Exode 18.1";
                TextFinQuiz.Text = "Bravo !";
                BlocImage06.IsVisible = false;
                BlocQuestion06.IsVisible = false;
                Proposition0601.IsVisible = false;
                Proposition0602.IsVisible = false;
                Proposition0603.IsVisible = false;
                Proposition0604.IsVisible = false;
                ReponseQuestion06.IsVisible = false;
                BlocValidationBas06.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas06.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, c'est Jéthro le beau-père de Moïse, prêtre de Madian qui reconnut la grandeur de l'Eternel." + Environment.NewLine + "Exode 18.1";
                TextFinQuiz.Text = "Dommage !";
                BlocImage06.IsVisible = false;
                BlocQuestion06.IsVisible = false;
                Proposition0601.IsVisible = false;
                Proposition0602.IsVisible = false;
                Proposition0603.IsVisible = false;
                Proposition0604.IsVisible = false;
                ReponseQuestion06.IsVisible = false;
                BlocValidationBas06.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas06.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked06(object sender, EventArgs e)
        {
            BlocImage07.IsVisible = true;
            BlocQuestion07.IsVisible = true;
            Proposition0701.IsVisible = true;
            Proposition0702.IsVisible = true;
            Proposition0703.IsVisible = true;
            Proposition0704.IsVisible = true;
            ReponseQuestion07.IsVisible = true;
            BlocValidationBas07.IsVisible = true;
            BlocSuivantBas06.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas05.IsVisible = false;
        }
        /*--------Reponse 07--------*/
        public void Reponse0701Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion07.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0702Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion07.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0703Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion07.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0704Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion07.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked07(object sender, EventArgs e)
        {
            if (ReponseQuestion07.Text == "Vous avez répondu : Gethsémané")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, c'est dans le jardin de Gethsémané, après la nuit de prière que Jésus fut arrêté par la trahison de Judas." + Environment.NewLine + "Marc 14.32-46";
                TextFinQuiz.Text = "bravo !";
                BlocImage07.IsVisible = false;
                BlocQuestion07.IsVisible = false;
                Proposition0701.IsVisible = false;
                Proposition0702.IsVisible = false;
                Proposition0703.IsVisible = false;
                Proposition0704.IsVisible = false;
                ReponseQuestion07.IsVisible = false;
                BlocValidationBas07.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas07.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, c'est dans le jardin de Gethsémané, après la nuit de prière que Jésus fut arrêté par la trahison de Judas." + Environment.NewLine + "Marc 14.32-46";
                TextFinQuiz.Text = "Dommage !";
                BlocImage07.IsVisible = false;
                BlocQuestion07.IsVisible = false;
                Proposition0701.IsVisible = false;
                Proposition0702.IsVisible = false;
                Proposition0703.IsVisible = false;
                Proposition0704.IsVisible = false;
                ReponseQuestion07.IsVisible = false;
                BlocValidationBas07.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas07.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked07(object sender, EventArgs e)
        {
            BlocImage08.IsVisible = true;
            BlocQuestion08.IsVisible = true;
            Proposition0801.IsVisible = true;
            Proposition0802.IsVisible = true;
            Proposition0803.IsVisible = true;
            Proposition0804.IsVisible = true;
            ReponseQuestion08.IsVisible = true;
            BlocValidationBas08.IsVisible = true;
            BlocSuivantBas07.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas06.IsVisible = false;
        }
        /*--------Reponse 08--------*/
        public void Reponse0801Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion08.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0802Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion08.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0803Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion08.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0804Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion08.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked08(object sender, EventArgs e)
        {
            if (ReponseQuestion08.Text == "Vous avez répondu : Sodome et Gomorrhe")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, ce sont les villes de Sodome et Gomorrhe qui furent détruites par le feu de Dieu." + Environment.NewLine + "Genèse 19.29";
                TextFinQuiz.Text = "bravo !";
                BlocImage08.IsVisible = false;
                BlocQuestion08.IsVisible = false;
                Proposition0801.IsVisible = false;
                Proposition0802.IsVisible = false;
                Proposition0803.IsVisible = false;
                Proposition0804.IsVisible = false;
                ReponseQuestion08.IsVisible = false;
                BlocValidationBas08.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas08.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, ce sont les villes de Sodome et Gomorrhe qui furent détruites par le feu de Dieu." + Environment.NewLine + "Genèse 19.29";
                TextFinQuiz.Text = "Dommage !";
                BlocImage08.IsVisible = false;
                BlocQuestion08.IsVisible = false;
                Proposition0801.IsVisible = false;
                Proposition0802.IsVisible = false;
                Proposition0803.IsVisible = false;
                Proposition0804.IsVisible = false;
                ReponseQuestion08.IsVisible = false;
                BlocValidationBas08.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas08.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked08(object sender, EventArgs e)
        {
            BlocImage09.IsVisible = true;
            BlocQuestion09.IsVisible = true;
            Proposition0901.IsVisible = true;
            Proposition0902.IsVisible = true;
            Proposition0903.IsVisible = true;
            Proposition0904.IsVisible = true;
            ReponseQuestion09.IsVisible = true;
            BlocValidationBas09.IsVisible = true;
            BlocSuivantBas08.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas07.IsVisible = false;
        }
        /*--------Reponse 09--------*/
        public void Reponse0901Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion09.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0902Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion09.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0903Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion09.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0904Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion09.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked09(object sender, EventArgs e)
        {
            if (ReponseQuestion09.Text == "Vous avez répondu : 7")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, les lettres prophétiques adressés dans l'Apocalypse sont au nombre de 7." + Environment.NewLine + "Apocalypse 2 & 3";
                TextFinQuiz.Text = "bravo !";
                BlocImage09.IsVisible = false;
                BlocQuestion09.IsVisible = false;
                Proposition0901.IsVisible = false;
                Proposition0902.IsVisible = false;
                Proposition0903.IsVisible = false;
                Proposition0904.IsVisible = false;
                ReponseQuestion09.IsVisible = false;
                BlocValidationBas09.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas09.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, les lettres prophétiques adressés dans l'Apocalypse sont au nombre de 7." + Environment.NewLine + "Apocalypse 2 & 3";
                TextFinQuiz.Text = "Dommage !";
                BlocImage09.IsVisible = false;
                BlocQuestion09.IsVisible = false;
                Proposition0901.IsVisible = false;
                Proposition0902.IsVisible = false;
                Proposition0903.IsVisible = false;
                Proposition0904.IsVisible = false;
                ReponseQuestion09.IsVisible = false;
                BlocValidationBas09.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas09.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked09(object sender, EventArgs e)
        {
            BlocImage10.IsVisible = true;
            BlocQuestion10.IsVisible = true;
            Proposition1001.IsVisible = true;
            Proposition1002.IsVisible = true;
            Proposition1003.IsVisible = true;
            Proposition1004.IsVisible = true;
            ReponseQuestion10.IsVisible = true;
            BlocValidationBas10.IsVisible = true;
            BlocSuivantBas10.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas09.IsVisible = false;
        }
        /*--------Reponse 10--------*/
        public void Reponse1001Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion10.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse1002Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion10.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse1003Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion10.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse1004Clicked(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion10.Text = $"Vous avez répondu : {button.Content}";
        }
        public void ValiderReponseClicked10(object sender, EventArgs e)
        {
            if (ReponseQuestion10.Text == "Vous avez répondu : Des lions")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, ce sont des lions dans la fosse qui ne mangèrent pas Daniel." + Environment.NewLine + "Daniel 6.23-24";
                TextFinQuiz.Text = "bravo !";
                BlocImage10.IsVisible = false;
                BlocQuestion10.IsVisible = false;
                Proposition1001.IsVisible = false;
                Proposition1002.IsVisible = false;
                Proposition1003.IsVisible = false;
                Proposition1004.IsVisible = false;
                ReponseQuestion10.IsVisible = false;
                BlocValidationBas10.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceOk.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas10.IsVisible = true;

            }
            else
            {
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, ce sont des lions dans la fosse qui ne mangèrent pas Daniel." + Environment.NewLine + "Daniel 6.23-24";                
                TextFinQuiz.Text = "Dommage !";
                BlocImage10.IsVisible = false;
                BlocQuestion10.IsVisible = false;
                Proposition1001.IsVisible = false;
                Proposition1002.IsVisible = false;
                Proposition1003.IsVisible = false;
                Proposition1004.IsVisible = false;
                ReponseQuestion10.IsVisible = false;
                BlocValidationBas10.IsVisible = false;
                BlocFinQuiz.IsVisible = true;
                BlocPouceKo.IsVisible = true;
                BlocExplicationReponse.IsVisible = true;
                BlocSuivantBas10.IsVisible = true;
            }
        }
        public void QuestionSuivanteClicked10(object sender, EventArgs e)
        {
            pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
            BlocSuivantBas10.IsVisible = false;
            BlocFinQuiz.IsVisible = true;
            TextFinQuiz.FontSize = 20;
            TextFinQuiz.Text = "Bravo, vous avez fini le quiz !" + Environment.NewLine + "Vous avez répondu à " + nbreQuestion + " questions sur " + totalQuestion + "." + Environment.NewLine + "Vous avez " + pourcentage + "% de réussite !" + Environment.NewLine + "Vous avez " + score + " bonnes réponses sur " + totalQuestion + " !";
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
        }
    }
}