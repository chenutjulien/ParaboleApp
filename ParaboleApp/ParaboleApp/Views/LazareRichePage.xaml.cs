using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaboleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LazareRichePage : ContentPage
    {
        public LazareRichePage()
        {
            InitializeComponent();
        }
        public void ChoisirLazare(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            avatarLabel.Text = $"Vous avez choisi: {button.Content}";
        }
        public void ChoisirRiche(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            avatarLabel.Text = $"Vous avez choisi:{ button.Content}";
        }
        public void DebutButtonClicked(object sender, EventArgs e)
        {
            avatarLabel.IsVisible = false;

            if (avatarLabel.Text == "Vous avez choisi: Lazare")
            {
                Parabole03.IsVisible = true;
                Parabole03.Text = "Vous êtes un pauvre hère sans richesse qui vit de la générosité des gens. Votre vie est misérable, les chiens viennent lécher vos ulcères.\n" +
                    "Allongé devant la maison d'un riche, vous entendez que le repas se prépare. Qu'allez vous faire ?";
                ChoixAvatar.IsVisible = false;
                DebutButton.IsVisible = false;
                FrapperPorteButton.IsVisible = true;
                AttendreButton.IsVisible = true;
                Choix.IsVisible = false;
            }
            else if (avatarLabel.Text == "Vous avez choisi: Le Riche")
            {
                Parabole03.IsVisible = true;
                Parabole03.Text = "Vous êtes un homme riche qui ne manque d'aucuns biens matériels, vous menez une vie joyeuse et insouciante dans l'opulence.\nVous voyez encore ce mendiant de Lazare affalé" +
                    "devant votre porte. Qu'allez vous faire ?";
                ChoixAvatar.IsVisible = false;
                DebutButton.IsVisible = false;
                SuperbeRepasButton.IsVisible = true;
                InvitationButton.IsVisible = true;
                Choix.IsVisible = false;
            }
            else
            {
                Parabole03.IsVisible = true;
                Parabole03.Text = "Vous n'avez pas choisi de role !";
            }
        }
        public void SuperbeRepasButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous voyez la table superbement chargée de victuailles, vous pensez à toutes vos richesses et cela suffit à chasser de votre pensée Lazare. Ainsi" +
                " vous commencez ce repas avec bon appétit. Qu'allez vous faire après ?";
            SuperbeRepasButton.IsVisible = false;
            InvitationButton.IsVisible = false;
            ProfiterButton.IsVisible = true;
            PartagerRichesseButton.IsVisible = true;
            Choix.IsVisible = false;
        }
        public void InvitationButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "En voyant le pauvre Lazare couché devant votre porte, le remords vous prend et décidez de l'inviter à partager votre repas, vous décidez de lui donner" +
                " assez d'or pour qu'il puisse repartir d'un bon pied dans la vie et vous décidez d'être agréable à l'Eternel.";
            SuperbeRepasButton.IsVisible = false;
            InvitationButton.IsVisible = false;
            ProfiterButton.IsVisible = false;
            PartagerRichesseButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
            Choix.IsVisible = false;
        }

        public void FrapperPorteButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous décidez de frapper à la porte et d'invoquer la générosité du riche afin de pouvoir manger un peu. Vous n'en pouvez plus de la faim et de la misère !";
            FrapperPorteButton.IsVisible = false;
            AttendreButton.IsVisible = false;
            VolerButton.IsVisible = true;
            MangerRestesButton.IsVisible = true;
            Choix.IsVisible = false;
        }
        public void AttendreButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Trop las pour avoir envie de vous lever, vous vous contentez de rester allongé sur le sol pendant que les chiens vous reniflent.";
            FrapperPorteButton.IsVisible = false;
            AttendreButton.IsVisible = false;
            VolerButton.IsVisible = true;
            MangerRestesButton.IsVisible = true;
            Choix.IsVisible = false;
        }
        public void VolerButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Après avoir frappé, le riche vous ouvre et vous lui réclamez l'aumone.Pendant qu'il à le dos tourné, vous en profitez pour lui voler de l'or. Mais celui-ci s'en aperçoit et vous fait chasser de devant" +
                " sa maison brutalement ! Le vol n'est pas une solution à la pauvreté. Il faut plutôt se confier en Dieu.";
            MangerRestesButton.IsVisible = false;
            VolerButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void MangerRestesButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Les serviteurs jettent les restes par la fenêtre et difficilement, vous en récuperez. Las, dans la nuit, vous décedez ainsi que le riche Celui-ci est enterré avec les honneurs terrestres tandis que vous, ce sont des anges qui viennent vous chercher. Vous vous retrouvez au coté d'Abraham" +
                " , en surplombant un abîme tandis que le riche se retrouve en bas souffrant des tourments.\nCe dernier supplie Abraham de vous envoyer pour le rafraichir, qu'allez vous faire ?";
            MangerRestesButton.IsVisible = false;
            VolerButton.IsVisible = false;
            RafraichirButton.IsVisible = true;
            RegarderSilenceButton.IsVisible = true;
        }
        public void ProfiterButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous faites un festin et decider de jouir des plaisirs de la vie. Sauf que la mort vous surprend. Vous êtes enterré avec de grands honneurs tandis que" +
                " Lazare le pauvre, décédé en même temps que vous disparait sans laisser de trace, emporté auprès d'Abraham par des anges. Plus tard, vous voila dans un abîme, souffrant de" +
                " grands tourments, vous apercevez Abraham et Lazare vous surplombant. Qu'allez vous faire ?";
            ProfiterButton.IsVisible = false;
            PartagerRichesseButton.IsVisible = false;
            ReclamerBoireButton.IsVisible = true;
            HurlerColereButton.IsVisible = true;
        }
        public void PartagerRichesseButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous donner la moitié de vos richesses à Lazare et devenez son ami, prenant soin de lui. Hélas, la mort vous surprend tous les deux et seul L'Eternel" +
                " sait ce qu'il advient de vous. Mais avoir sacrifié vos bien terrestres vous sera rendu au centuple dans le royaume du Père Céleste. C'est une bonne chose.";
            PartagerRichesseButton.IsVisible = false;
            ProfiterButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void RafraichirButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Pris de pitié en voyant sa souffrance, vous décidez d'aller le secourir mais Abraham vous arrete. Le père de la Foi déclare : ''Il a reçu ses biens sur la terre" +
                " pendant que toi tu n'avais rien. A toi de profiter maintenant. Il y a un grand abîme que tu ne peux franchir ni eux non plus.''";
            RafraichirButton.IsVisible = false;
            RegarderSilenceButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void RegarderSilenceButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous écoutez en silence le riche reclamer à boire mais vous le regarder sans bouger. Celui-ci continue de supplier, qu'allez vous faire ?";
            RafraichirButton.IsVisible = false;
            RegarderSilenceButton.IsVisible = false;
            EcouterAbrahamButton.IsVisible = true;
            LaisserConvaincreButton.IsVisible = true;
        }
        public void ReclamerBoireButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Il fait horriblement chaud, vous souffrez. Vous suppliez Abraham de vous envoyer Lazare tremper son doigt pour vous raffraichir. Mais il vous répond" +
                " que vous avez reçu vos biens sur terre pendant que Lazare n'avait que des maux. Maintenant, il faut échanger les rôles. Vous soupirez avec force regrets.\nQu'allez vous faire ?";
            ReclamerBoireButton.IsVisible = false;
            HurlerColereButton.IsVisible = false;
            DemanderLazarePrevenirButton.IsVisible = true;
            JustifierButton.IsVisible = true;
        }
        public void HurlerColereButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Face à la situation, vous laissez éclater votre colère, arguant du fait que vous laissiez Lazare profiter de vos restes. Abraham secoue la tête et répond" +
                " que vous avez reçu vos biens sur terre pendant que Lazare n'avait que des maux. Il est juste maintenant, que Lazare soit consolé et pas vous. On récolte ce que l'on sème.";
            ReclamerBoireButton.IsVisible = false;
            HurlerColereButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void EcouterAbrahamButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous laisser parler Abraham qui déclare d'une voix forte : ''Mon enfant, souviens-toi que tu as reçu tes biens pendant ta vie, et que Lazare a eu les maux pendant la sienne ; maintenant il est ici consolé, et toi, tu souffres.''" +
                " Le riche acquièse avec regrets et demande alors de vous envoyer prévenir ses frères pour leurs éviter cet endroit. Qu'allez vous faire ?";
            EcouterAbrahamButton.IsVisible = false;
            LaisserConvaincreButton.IsVisible = false;
            VoirFreresButton.IsVisible = true;
            LazarePrierButton.IsVisible = true;
        }
        public void LaisserConvaincreButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Pris de pitié en voyant sa souffrance, vous décidez d'aller le secourir mais Abraham vous arrete. Le père de la Foi déclare : ''Il a reçu ses biens sur la terre" +
                " pendant que toi tu n'avais rien. A toi de profiter maintenant. Il y a un grand abîme que tu ne peux franchir ni lui non plus''.\nVous ne pouvez aller contre la volonté" +
                " du Père.";
            EcouterAbrahamButton.IsVisible = false;
            LaisserConvaincreButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void DemanderLazarePrevenirButtonclicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous demandez à Abraham d'envoyer Lazare prévenir ses cinq frères pour leurs éviter de subir cela. Mais Abraham refuse et rétorque qu'ils ont Moïse" +
                " et les prophètes. Qu'allez vous faire ?";
            DemanderLazarePrevenirButton.IsVisible = false;
            JustifierButton.IsVisible = false;
            InsisterButton.IsVisible = true;
            RichePrierButton.IsVisible = true;
        }
        public void JustifierButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous baissez la tête devant ce que dit Abraham mais vous cherchez à vous justifier. En vain, Dieu qui voit tout sait la dureté de votre coeur. Il vaut mieux" +
                " amasser pour le royaume céleste que sur la terre.";
            DemanderLazarePrevenirButton.IsVisible = false;
            JustifierButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void VoirFreresButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous souhaitez être agréable au riche et demandez à Abraham de l'aider mais celui-ci refuse. Il vous dit que si ces frères n'écoutent pas Moîse et les prophètes" +
                " ,ils ne croiront pas quelqu'un qui ressuciterait des morts. Vous acquiesez.";
            VoirFreresButton.IsVisible = false;
            LazarePrierButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void PrierButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Après avoir entendu Abraham répondre que si ces frères n'écoutent pas Moîse et les prophètes, ils ne croiront pas quelqu'un qui ressuciterait des morts," +
                " \n vous décidez de prier pour les cinq frères. Ce qu'il en adviendra, seul Dieu le sait, car il est Souverain en toutes choses.";
            VoirFreresButton.IsVisible = false;
            LazarePrierButton.IsVisible = false;
            RichePrierButton.IsVisible = false;
            InsisterButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        public void InsisterButtonClicked(object sender, EventArgs e)
        {
            Parabole03.IsVisible = true;
            Parabole03.Text = "Vous insistez auprès d'Abraham pour que vos frères évitent les tourments comme vous mais Abraham reste ferme: Si ils n'écoutent pas Moîse et les prophètes, ils ne croiront pas quelqu'un qui ressuciterait des morts.\n" +
                "Nos actions sur terre ont des conséquences pour notre vie après.";
            RichePrierButton.IsVisible = false;
            InsisterButton.IsVisible = false;
            DecouvrirParaboleButton.IsVisible = true;
        }
        async void DecouvrirParaboleButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LazareRicheExplication));
        }
    }
}