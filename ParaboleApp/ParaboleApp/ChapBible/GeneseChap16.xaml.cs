using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.ChapBible
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneseChap16 : ContentPage
    {
        public GeneseChap16()
        {
            InitializeComponent();
        }
        async void SuivantClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap17));
        }
        async void PrecedentClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap15));
        }
    }
}