using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap03 : ContentPage
    {
        public GeneseChap03()
        {
            InitializeComponent();
        }
        async void SuivantClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap04));
        }
        async void PrecedentClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap02));
        }
    }
}