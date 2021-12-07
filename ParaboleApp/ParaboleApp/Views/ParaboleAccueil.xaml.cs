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
    public partial class ParaboleAccueil : ContentPage
    {
        public ParaboleAccueil()
        {
            InitializeComponent();
        }
        async void ButtonJeuneHommeRiche(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(JeuneHommeRichePage));
        }
        async void ButtonFilsProdigue(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(FilsProdiguePage));
        }
        async void ButtonLazareRiche(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LazareRichePage));
        }
        async void ButtonServiteurCruel(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ServiteurCruelPage));
        }
    }
}