using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap02 : ContentPage
    {
        public GeneseChap02()
        {
            InitializeComponent();
        }
        async void SuivantClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap03));
        }
        async void PrecedentClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap01));
        }
    }
}