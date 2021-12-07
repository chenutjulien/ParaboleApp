using ParaboleApp.ChapBible;
using ParaboleApp.Views;
using Xamarin.Forms;

namespace ParaboleApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            /*Route pour les paraboles*/
            Routing.RegisterRoute(nameof(JeuneHommeRichePage), typeof(JeuneHommeRichePage));
            Routing.RegisterRoute(nameof(FilsProdiguePage), typeof(FilsProdiguePage));
            Routing.RegisterRoute(nameof(LazareRichePage), typeof(LazareRichePage));
            Routing.RegisterRoute(nameof(ServiteurCruelPage), typeof(ServiteurCruelPage));

            /*Route pour les explications de paraboles*/
            Routing.RegisterRoute(nameof(FilsProdigueExplicationPage), typeof(FilsProdigueExplicationPage));
            Routing.RegisterRoute(nameof(JeuneHommeRicheExplicationPage), typeof(JeuneHommeRicheExplicationPage));
            Routing.RegisterRoute(nameof(LazareRicheExplication), typeof(LazareRicheExplication));
            Routing.RegisterRoute(nameof(ServiteurCruelExplication), typeof(ServiteurCruelExplication));

            /*Route pour le sommaire de la Bible*/
            Routing.RegisterRoute(nameof(Bible), typeof(Bible));
            Routing.RegisterRoute(nameof(SommaireGenese), typeof(SommaireGenese));

            /*Route pour la Genese*/
            Routing.RegisterRoute(nameof(GeneseChap01), typeof(GeneseChap01));
            Routing.RegisterRoute(nameof(GeneseChap02), typeof(GeneseChap02));
            Routing.RegisterRoute(nameof(GeneseChap03), typeof(GeneseChap03));
            Routing.RegisterRoute(nameof(GeneseChap04), typeof(GeneseChap04));
            Routing.RegisterRoute(nameof(GeneseChap05), typeof(GeneseChap05));
            Routing.RegisterRoute(nameof(GeneseChap06), typeof(GeneseChap06));
            Routing.RegisterRoute(nameof(GeneseChap07), typeof(GeneseChap07));
            Routing.RegisterRoute(nameof(GeneseChap08), typeof(GeneseChap08));
            Routing.RegisterRoute(nameof(GeneseChap09), typeof(GeneseChap09));
            Routing.RegisterRoute(nameof(GeneseChap10), typeof(GeneseChap10));
            Routing.RegisterRoute(nameof(GeneseChap11), typeof(GeneseChap11));
            Routing.RegisterRoute(nameof(GeneseChap12), typeof(GeneseChap12));
            Routing.RegisterRoute(nameof(GeneseChap13), typeof(GeneseChap13));
            Routing.RegisterRoute(nameof(GeneseChap14), typeof(GeneseChap14));
            Routing.RegisterRoute(nameof(GeneseChap15), typeof(GeneseChap15));
            Routing.RegisterRoute(nameof(GeneseChap16), typeof(GeneseChap16));
            Routing.RegisterRoute(nameof(GeneseChap17), typeof(GeneseChap17));
            Routing.RegisterRoute(nameof(GeneseChap18), typeof(GeneseChap18));
            Routing.RegisterRoute(nameof(GeneseChap19), typeof(GeneseChap19));
            Routing.RegisterRoute(nameof(GeneseChap20), typeof(GeneseChap20));

            /*Route pour les quiz*/
            Routing.RegisterRoute(nameof(QuizHistoire), typeof(QuizHistoire));
            Routing.RegisterRoute(nameof(QuizHistoire02), typeof(QuizHistoire02));
        }

    }
}
