using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap04 : ContentPage
    {
        public GeneseChap04()
        {
            InitializeComponent();
        }
        async void SuivantClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap05));
        }
        async void PrecedentClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap03));
        }
    }
}