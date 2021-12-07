using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap09 : ContentPage
    {
        public GeneseChap09()
        {
            InitializeComponent();
        }
        async void SuivantClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap10));
        }
        async void PrecedentClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap08));
        }
    }
}