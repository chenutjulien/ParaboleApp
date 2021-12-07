using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap01 : ContentPage
    {
        public GeneseChap01()
        {
            InitializeComponent();
        }
        async void SuivantClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap02));
        }
    }
}