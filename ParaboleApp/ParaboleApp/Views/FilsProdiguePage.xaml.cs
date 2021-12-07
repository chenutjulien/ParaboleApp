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
    public partial class FilsProdiguePage : ContentPage
    {
        public FilsProdiguePage()
        {
            InitializeComponent();
        }
        public void HeritageButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Père, je veux découvrir le monde, donne moi la part d'héritage qui me revient !\nLe père acquiesa et lui donna ce qui lui était dû." +
                "\nAprès avoir récupéré votre part d'héritage, vous allez de part le monde pour découvrir de nouvelles choses. Qu'allez vous faire de cet argent ?";
            HeritageButton.IsVisible = false;
            FeteButton.IsVisible = false;
            InvestirButton.IsVisible = true;
            DebaucheButton.IsVisible = true;
        }
        public void FeteButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Père, j'ai besoin que l'on organise une fête pour moi !\nLe père secoua la tête et lui répondit : ``Prend donc exemple sur ton frère ainé et aide nous dans les travaux plutôt !"
                + "\nIl n'est pas bon de penser qu'a s'amuser, nous avons d'abord des devoirs et des responsabilités, envers Dieu d'abord, ensuite ceux qui nous entourent.";
            HeritageButton.IsVisible = false;
            FeteButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;

        }
        public void InvestirButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Vous décidez de placer votre argent pour le faire fructifier et de vivre sur les revenus générés. C'est une sage décision.";
            InvestirButton.IsVisible = false;
            DebaucheButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void DebaucheButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Enfin la belle vie ! Soirée, belles rencontres et plaisir, rien n'est trop pour votre amusement !\n" +
                "Mais à force de dépenses inconsidérés, il arriva ce qui était prévu, l'argent vint à manquer et vous vous retrouvez sans le sou ! Qu'allez vous faire ?";
            InvestirButton.IsVisible = false;
            DebaucheButton.IsVisible = false;
            PourceauxButton.IsVisible = true;
            QuemanderButton.IsVisible = true;
        }
        public void PourceauxButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Vous devenez gardien de porc auprès d'un maître dur, vous en souffrez cruellement sachant que les porcs sont mieux traités que vous !\n" +
                "La vie est dure, vous ne pouvez même pas manger les carouges des pourceaux, il est temps de se décider !";
            PourceauxButton.IsVisible = false;
            QuemanderButton.IsVisible = false;
            VolButton.IsVisible = true;
            RevenirButton.IsVisible = true;
        }
        public void QuemanderButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Vous demandez à vos amis de festivités de vous aider mais ces derniers, voyant que vous n'avez plus de ressources vous tournent le dos et vous laisse démuni." +
                "\nFaire l'aumone auprès de ceux que l'on amusait n'est jamais une bonne chose.";
            PourceauxButton.IsVisible = false;
            QuemanderButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void VolButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Vous décidez de voler votre méchant maître mais mal vous en a pris car celui-ci fait donner sa garde et vous finissez misérable en prison." +
                "\nLe vol n'est jamais une solution aux yeux de Dieu, il faut plutôt invoquer son soutien.";
            VolButton.IsVisible = false;
            RevenirButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void RevenirButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Vous reconnaissez avoir péché contre votre père et mal agi. Vous décidez d'aller demander son pardon et de revenir à la maison.\n" +
                "En approchant de la maison, vous voyez au loin votre père qui semble vous attendre puis qui se précipite vers vous, les yeux pleins de larmes de joie. Qu'allez vous faire ?";
            RevenirButton.IsVisible = false;
            VolButton.IsVisible = false;
            ReclamerButton.IsVisible = true;
            PardonButton.IsVisible = true;
        }
        public void ReclamerButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "J'ai faim et soif Père, restaure moi et donne moi la place qui m'est du ! Le père, en entendant cela fut peiné, secoua la tête et repartit tristement." +
                "\nIl faut faire preuve d'humilité quand on vient demander pardon.";
            ReclamerButton.IsVisible = false;
            PardonButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void PardonButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Père, j'ai péché contre toi et le ciel, je ne mérite plus d'être ton fils. Mais le père s'écria : Réjouissons nous et donnons lui une belle tunique, tuons le veau gras pour célébrer le retour de mon fils perdu !" +
                "\nLe fils ainé rentrant des champs, entendit la fête et s'enquit de la raison. Il en fut irrité et ne voulut point rentrer dans la maison. Qu'allez vous faire ?";
            ReclamerButton.IsVisible = false;
            PardonButton.IsVisible = false;
            DiscuterButton.IsVisible = true;
            PereParlerButton.IsVisible = true;
        }
        public void DiscuterButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Vous avez beau discuter, celui-ci ne veux rien entendre, vous accusant de beaucoup de choses. Cette dispute sans fin fend le coeur de votre père." +
                "\nQuelques soient les arguments, il est important de laisser l'amour guider nos paroles.";
            DiscuterButton.IsVisible = false;
            PereParlerButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        public void PereParlerButtonClicked(object sender, EventArgs e)
        {
            Parabole02.Text = "Mon fils, tout ce temps, tu étais avec moi et ce que je possède est à toi, mais nous devons nous réjouir, car ton frère qui était disparu est revenu, il est vivant à nouveau !";
            DiscuterButton.IsVisible = false;
            PereParlerButton.IsVisible = false;
            DecouvrirButton.IsVisible = true;
        }
        async void DecouvrirParaboleClicked(object sender, EventArgs eventArgs)
        {
            await Shell.Current.GoToAsync(nameof(FilsProdigueExplicationPage));
        }
    }
}