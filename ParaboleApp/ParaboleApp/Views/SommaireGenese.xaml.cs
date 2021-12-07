using ParaboleApp.ChapBible;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SommaireGenese : ContentPage
    {
        public SommaireGenese()
        {
            InitializeComponent();
        }
        async void RetourLivreClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Bible));
        }
        async void Chap01Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap01));
        }
        async void Chap02Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap02));
        }
        async void Chap03Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap03));
        }
        async void Chap04Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap04));
        }
        async void Chap05Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap05));
        }
        async void Chap06Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap06));
        }
        async void Chap07Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap07));
        }
        async void Chap08Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap08));
        }
        async void Chap09Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap09));
        }
        async void Chap10Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap10));
        }
        async void Chap11Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap11));
        }
        async void Chap12Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap12));
        }
        async void Chap13Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap13));
        }
        async void Chap14Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap14));
        }
        async void Chap15Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap15));
        }
        async void Chap16Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap16));
        }
        async void Chap17Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap17));
        }
        async void Chap18Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap18));
        }
        async void Chap19Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap19));
        }
        async void Chap20Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GeneseChap20));
        }
    }
}