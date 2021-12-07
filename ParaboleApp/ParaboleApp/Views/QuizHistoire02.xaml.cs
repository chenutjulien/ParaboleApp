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
    public partial class QuizHistoire02 : ContentPage
    {
        private int score = 0;
        private int nbreQuestion = 0;
        private int totalQuestion = 10;
        int pourcentage;
        public QuizHistoire02()
        {
            InitializeComponent();
        }
        void StartTimer_Clicked(object sender, System.EventArgs e)
        {
            /*Pour gérer le minuteur*/
            var minutes = 1;
            var seconds = 0;

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
        public void Reponse0101Clicked (object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            ReponseQuestion01.Text = $"Vous avez répondu : {button.Content}";
        }
        public void Reponse0102Clicked (object sender, CheckedChangedEventArgs e)
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
        public void ValiderReponseClicked (object sender, EventArgs e)
        {
            if (ReponseQuestion01.Text == "Vous avez répondu : Simon")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, le véritable de nom de Pierre est Simon." + Environment.NewLine + "Jean 1.42";
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
                ExplicationReponse.Text = "En effet, le véritable de nom de Pierre est Simon." + Environment.NewLine + "Jean 1.42";
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
        public void QuestionSuivanteClicked01 (object sender, EventArgs e)
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
            if (ReponseQuestion02.Text == "Vous avez répondu : Goliath")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, ce fut Goliath qui fut vaincu par David à l'aide de sa fronde." + Environment.NewLine + "1Samuel 17.50";
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
                ExplicationReponse.Text = "En effet, ce fut Goliath qui fut vaincu par David à l'aide de sa fronde." + Environment.NewLine + "1Samuel 17.50";
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
            if (ReponseQuestion03.Text == "Vous avez répondu : Le serpent")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, c'est le serpent qui tenta Eve dans le jardin." + Environment.NewLine + "Genèse 3.1";
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
                ExplicationReponse.Text = "En effet, c'est le serpent qui tenta Eve dans le jardin." + Environment.NewLine + "Genèse 3.1";
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
            if (ReponseQuestion04.Text == "Vous avez répondu : Parler la même langue")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, tous les habitants de la terre parlaient à ce moment la même langue." + Environment.NewLine + "Genèse 11.1";
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
                ExplicationReponse.Text = "En effet, tous les habitants de la terre parlaient à ce moment la même langue." + Environment.NewLine + "Genèse 11.1";
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
            if (ReponseQuestion05.Text == "Vous avez répondu : Imposer les mains")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Ananias imposa les mains sur Saûl pour le guérir de sa cécité." + Environment.NewLine + "Actes 9.17";
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
                ExplicationReponse.Text = "En effet, Ananias imposa les mains sur Saûl pour le guérir de sa cécité." + Environment.NewLine + "Actes 9.17";
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
            if (ReponseQuestion06.Text == "Vous avez répondu : Lazare")
            {
                score++;
                nbreQuestion++;
                pourcentage = (int)Math.Round((double)(score * 100) / nbreQuestion);
                Score.Text = "score : " + score;
                ExplicationReponse.TextColor = Color.Green;
                ExplicationReponse.Text = "En effet, Jésus ressuscita Lazare quatre jours après sa mort." + Environment.NewLine + "Jean 11.43-44";
                TextFinQuiz.Text = "bravo !";
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
                ExplicationReponse.Text = "En effet, Jésus ressuscita Lazare quatre jours après sa mort." + Environment.NewLine + "Jean 11.43-44";
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
            /*BlocImage06.IsVisible = true;
            BlocQuestion06.IsVisible = true;
            Proposition0601.IsVisible = true;
            Proposition0602.IsVisible = true;
            Proposition0603.IsVisible = true;
            Proposition0604.IsVisible = true;
            ReponseQuestion06.IsVisible = true;
            BlocValidationBas06.IsVisible = true;*/
            BlocSuivantBas06.IsVisible = false;
            BlocFinQuiz.IsVisible = false;
            BlocPouceOk.IsVisible = false;
            BlocPouceKo.IsVisible = false;
            BlocExplicationReponse.IsVisible = false;
            BlocSuivantBas05.IsVisible = false;
        }
    }
}