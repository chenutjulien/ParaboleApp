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
    public partial class JeuneHommeRichePage : ContentPage
    {
        public JeuneHommeRichePage()
        {
            InitializeComponent();
        }
        public void EchecButtonClicked(object sender, EventArgs e)
        {
            Parabole01.Text = "Vous regardez passer Jésus après l'avoir salué. Mais comme vous n'avez rien dit, il s'éloigne. Dommage, vous avez raté l'occasion de parler avec le Bon Berger.";
            EchecButton.IsVisible = false;
            ParlerButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void ParlerButtonClicked(object sender, EventArgs e)
        {
            Parabole01.Text = "Vous le saluez en lui disant : ''Salutations bon Maître !'' et Il vous répond : ''Pourquoi m'appelles-tu bon Maître ? Il n'y a de bon que celui qui m'envoit !'' ";
            EchecButton.IsVisible = false;
            ParlerButton.IsVisible = false;
            QuestionSalutButton.IsVisible = true;
            RomainsButton.IsVisible = true;
        }
        public void ParlerSalutButtonClicked(object sender, EventArgs e)
        {
            Parabole01.Text = "Que dois-je faire pour hériter de la Vie Eternelle ? Jésus répondit : ''Tu connais la Loi : Tu ne commettras point adultère ; tu ne tueras point ; tu ne déroberas point ; tu ne diras point de faux témoignage ; tu ne feras tort à personne ; honore ton père et ta mère...''";
            QuestionSalutButton.IsVisible = false;
            RomainsButton.IsVisible = false;
            RespectLoiButton.IsVisible = true;
            RienFaireButton.IsVisible = true;
        }
        public void RomainsTempsButtonClicked(object sender, EventArgs e)
        {
            Parabole01.Text = "En demandant à Jésus si les mauvaises récoltes sont imputables aux romains, vous provoquez en lui un soupir. Vous pensez que les romains sont responsables du mauvais temps ?" +
                "\nIl secoua la tête et poursuivit sa route. Dommage, vous auriez pu être enseigné avec  ";
            QuestionSalutButton.IsVisible = false;
            RomainsButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void RespectLoiButtonclicked(object sender, EventArgs e)
        {
            Parabole01.Text = "Ayant écouté la réponse de Jésus, vous lui répondez: ''Le jeune homme répondit : Oui, j'ai respecté toutes les Lois de Moïse depuis mon plus jeune age !''" +
                "\nEcoutant cela, Jésus le regarda et l'aima.\nJésus dit au jeune homme: il te reste encore une chose: vend tes richesses et donne les aux pauvres, tu y gagneras un trésor dans le ciel et ensuite, suis moi.";
            RespectLoiButton.IsVisible = false;
            RienFaireButton.IsVisible = false;
            RefusPropositionButton.IsVisible = true;
            VendreSuivreButton.IsVisible = true;
        }
        public void RienFaireButtonClicked(object sender, EventArgs e)
        {
            Parabole01.Text = "Tout penaud, le jeune homme expliqua qu'il n'avait respecté ces Lois et que cela lui était trop dur.\nJésus soupira et continua sa route.\nDommage, vous avez raté le Salut avec Jésus.";
            RespectLoiButton.IsVisible = false;
            RienFaireButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void RefusPropositionButtonClicked(object sender, EventArgs e)
        {
            Parabole01.Text = "Face à la proposition de Jésus, vous reculez effrayé, vous partez tout triste car vous possedez de grands biens." +
                "\nJésus soupira et continua sa route.\nIl dit : Il est plus facile pour un chameau de passer par un trou d'aiguille que pour un riche d'accéder au royaume de mon Père !" +
                "\nDommage, vous avez raté l'occasion du salut avec Jésus.";
            RefusPropositionButton.IsVisible = false;
            VendreSuivreButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void VendreSuivreButtonClicked(object sender, EventArgs e)
        {
            Parabole01.Text = "Vous faites avec joie ce que vous demande Jésus et gagner le chemin de la vie éternelle.\nVous vous engagez sur le chemin étroit et rocailleux mais persevez dans le bon combat.\nFélicitations, mais n'oubliez pas qu'il faut perseverer.";
            RefusPropositionButton.IsVisible = false;
            VendreSuivreButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        async void DecouvrirParaboleClicked(object sender, EventArgs eventArgs)
        {
            await Shell.Current.GoToAsync(nameof(JeuneHommeRicheExplicationPage));
        }
    }
}