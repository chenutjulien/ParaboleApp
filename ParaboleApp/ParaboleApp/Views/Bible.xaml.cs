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
    public partial class Bible : ContentPage
    {
        public Bible()
        {
            InitializeComponent();
        }
        async void GeneseClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SommaireGenese));
        }
    }
}