using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap06 : ContentPage
    {
        public GeneseChap06()
        {
            InitializeComponent();
        }
        async void SuivantClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap07));
        }
        async void PrecedentClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap05));
        }
    }
}