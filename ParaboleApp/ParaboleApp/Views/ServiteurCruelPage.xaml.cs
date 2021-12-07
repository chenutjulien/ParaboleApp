using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiteurCruelPage : ContentPage
    {
        public ServiteurCruelPage()
        {
            InitializeComponent();
        }
        public void SupplierMaitreClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous décidez d'aller voir votre maître pour l'implorer de vous alleger votre dette. Celui-ci, annonca que vous serez vendu comme esclave, ainsi que votre femme" +
                " et vos enfants ainsi que toutes vos possessions jusqu'a ce que la dette fut acquittée. Qu'allez vous faire ?";
            SupplierMaitreButton.IsVisible = false;
            SenfuirLoinButton.IsVisible = false;
            ImplorerPitieButton.IsVisible = true;
            AttaquerMaitreButton.IsVisible = true;
        }
        public void SenfuirLoinClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous prenez vos jambes à votre cou et tenter de fuir mais les gardes de votre maître vous attrapent et vous finissez en tant qu'esclave ! Il ne faut pas fuir ses responsabilités.";
            SupplierMaitreButton.IsVisible = false;
            SenfuirLoinButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void ImplorerPitieClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Devant l'ampleur de la sanction, vous vous jettez à genoux devant le maître pour le supplier de vous faire grâce, invoquant sa bonté. BPlein de générosité, le maître " +
                "vous fait grâce et annule toute votre dette.\nVous repartez le coeur rempli de joie et dans la rue, vous croisez une de vos connaissances. Qu'allez vous faire ?";
            ImplorerPitieButton.IsVisible = false;
            AttaquerMaitreButton.IsVisible = false;
            PrendreNouvelleButton.IsVisible = true;
            RappelDetteButton.IsVisible = true;
        }
        public void AttaquerMaitreClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "En entendant cela, votre sang ne fait qu'un tour et plein de colère, vous bondissez sur le maître dans le but de vous venger. Mais les gardes veillent " +
                "et vous vous retrouvez rapidement au fond d'un cachot. La colère est mauvaise conseillère.";
            ImplorerPitieButton.IsVisible = false;
            AttaquerMaitreButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void PrendreNouvelleClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous allez saluer votre ami et vous enquérir de comment il va. Vous lui racontez avec joie la bonne nouvelle qui vous est arrivé. Il est bon d'être reconnaissant";
            PrendreNouvelleButton.IsVisible = false;
            RappelDetteButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void RappelDetteClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous interpellez votre ami et lui rappelez fermement qu'il vous doit cent deniers. Il répond avec tritesse qu'il n'as pas encore cette somme mais qu'il y travaille.\n" +
                "Qu'allez vous faire ?";
            PrendreNouvelleButton.IsVisible = false;
            RappelDetteButton.IsVisible = false;
            EtranglerButton.IsVisible = true;
            AnnulerDetteButton.IsVisible = true;
        }
        public void EtranglerClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous vous mettez en colère contre lui, l'attraper par le cou en l'étranglant et vous reclamez qu'il aille en prison jusqu'a ce que la dette soit remboursé. " +
                "Mais votre esclandre ne passe pas inaperçu et certains de vos compagnons, attristé par votre conduite vont rapporter l'incident au maitre. Ce dernier vous convoque à nouveau.\n" +
                "Qu'allez vous faire ?";
            EtranglerButton.IsVisible = false;
            AnnulerDetteButton.IsVisible = false;
            FuiteEncoreButton.IsVisible = true;
            AllerVoirButton.IsVisible = true;
        }
        public void AnnulerDetteClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous comprenez la situation et pour une si petite somme, vous acquiesez et laisser votre ami rembourser plus tard. Il n'est jamais vain de faire preuve de bonté.";
            EtranglerButton.IsVisible = false;
            AnnulerDetteButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void FuiteEncoreClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous prenez vos jambes à votre cou et tenter de fuir mais les gardes de votre maître vous attrapent et vous finissez en tant qu'esclave ! Il ne faut pas fuir ses responsabilités.";
            FuiteEncoreButton.IsVisible = false;
            AllerVoirButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void AllerVoirClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Une fois devant le maître, celui-ci irrité vous reproche : Cruel serviteur ! je t'avais remis ta dette en entier car tu m'avais supplié, " +
                "ne devais tu pas en faire autant avec ton ami ?.\nQue lui répondre";
            AllerVoirButton.IsVisible = false;
            FuiteEncoreButton.IsVisible = false;
            SupplierEncore.IsVisible = true;
            SeJustifierButton.IsVisible = true;
        }
        public void SupplierEncoreClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous implorez à nouveau la pitié du maître et vous prosternez devant lui. Mais en vain, très en colère, le maître vous livra aux bourreaux jusqu'a ce que vous ayez payé votre dû.";
            DecouvrirParaboleButton.IsVisible = true;
            SupplierEncore.IsVisible = false;
            SeJustifierButton.IsVisible = false;
        }
        public void SeJustifierClicked(object sender, EventArgs e)
        {
            Parabole04.Text = "Vous tentez de vous justifier en disant que la dette collecté aurait été pour lui mais en vain, très en colère, le maître vous livra aux bourreaux jusqu'a ce que vous ayez payé votre dû.";
            DecouvrirParaboleButton.IsVisible = true;
            SupplierEncore.IsVisible = false;
            SeJustifierButton.IsVisible = false;
        }

        async void DecouvrirParaboleClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ServiteurCruelExplication));
        }
    }
}