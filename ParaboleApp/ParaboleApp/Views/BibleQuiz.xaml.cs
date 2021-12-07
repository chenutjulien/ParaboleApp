using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BibleQuiz : ContentPage
    {
        public BibleQuiz()
        {
            InitializeComponent();
        }
        async public void QuizHistoireClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(QuizHistoire));
        }
        async public void QuizHistoire02Clicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(QuizHistoire02));
        }
    }
}