using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap08 : ContentPage
    {
        public GeneseChap08()
        {
            InitializeComponent();
        }
        async void SuivantClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap09));
        }
        async void PrecedentClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap07));
        }
    }
}