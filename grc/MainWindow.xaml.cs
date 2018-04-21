using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace grc
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MenuItem_HideAll();

        }

        private void MenuItem_Quit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Setup(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("setup");
        }

        private void MenuItem_Ventes(object sender, RoutedEventArgs e)
        {
            MenuItem_HideAll();
            BtnVentes.Background = Brushes.Cyan;

            LblVentesDocuments.Visibility = Visibility.Visible;
            LblVentesDocumentsDevis.Visibility = Visibility.Visible;
            LblVentesDocumentsCommandes.Visibility = Visibility.Visible;
            LblVentesDocumentsFactures.Visibility = Visibility.Visible;
            LblVentesDocumentsReglements.Visibility = Visibility.Visible;
            LblVentesDocumentsTickets.Visibility = Visibility.Visible;

            LblVentesClients.Visibility = Visibility.Visible;
            LblVentesClientsProspects.Visibility = Visibility.Visible;
            LblVentesClientsClients.Visibility = Visibility.Visible;
            LblVentesClientsContacts.Visibility = Visibility.Visible;
            LblVentesClientsFamilles.Visibility = Visibility.Visible;
            LblVentesClientsSFamilles.Visibility = Visibility.Visible;
            LblVentesClientsHistorique.Visibility = Visibility.Visible;
            LblVentesClientsStatistiques.Visibility = Visibility.Visible;

            LblVentesReglements.Visibility = Visibility.Visible;
            LblVentesReglementsEcheancier.Visibility = Visibility.Visible;
            LblVentesReglementsReglements.Visibility = Visibility.Visible;

        }

        private void MenuItem_Achats(object sender, RoutedEventArgs e)
        {
            MenuItem_HideAll();
            LblAchatsDocuments.Visibility = Visibility.Visible;
            LblAchatsDocumentsDemandes.Visibility = Visibility.Visible;
            LblAchatsDocumentsCommandes.Visibility = Visibility.Visible;
            LblAchatsDocumentsReception.Visibility = Visibility.Visible;
            LblAchatsDocumentsRetour.Visibility = Visibility.Visible;
            LblAchatsDocumentsFactures.Visibility = Visibility.Visible;
            LblAchatsDocumentsAvoirs.Visibility = Visibility.Visible;

            LblAchatsFournisseurs.Visibility = Visibility.Visible;
            LblAchatsFournisseursFournisseurs.Visibility = Visibility.Visible;
            LblAchatsFournisseursContacts.Visibility = Visibility.Visible;
            LblAchatsFournisseursFamilles.Visibility = Visibility.Visible;
            LblAchatsFournisseursSFamilles.Visibility = Visibility.Visible;
            LblAchatsFournisseursHistorique.Visibility = Visibility.Visible;
            LblAchatsFournisseursStatistiques.Visibility = Visibility.Visible;

            LblAchatsReglements.Visibility = Visibility.Visible;
            LblAchatsReglementsEcheancier.Visibility = Visibility.Visible;
            LblAchatsReglementsReglements.Visibility = Visibility.Visible;
        }

        private void MenuItem_Reglements(object sender, RoutedEventArgs e)
        {
            MenuItem_HideAll();
            LblReglementsClients.Visibility = Visibility.Visible;
            LblReglementsClientsEcheancier.Visibility = Visibility.Visible;
            LblReglementsClientsReglements.Visibility = Visibility.Visible;

            LblReglementsFournisseurs.Visibility = Visibility.Visible;
            LblReglementsFournisseursEcheancier.Visibility = Visibility.Visible;
            LblReglementsFournisseursReglements.Visibility = Visibility.Visible;

            
        }

        private void MenuItem_Stocks(object sender, RoutedEventArgs e)
        {
            MenuItem_HideAll();
            LblArticlesDocuments.Visibility = Visibility.Visible;
            LblArticlesDocumentsEntrees.Visibility = Visibility.Visible;
            LblArticlesDocumentsSorties.Visibility = Visibility.Visible;
            LblArticlesDocumentsInventaires.Visibility = Visibility.Visible;

            LblArticlesArticles.Visibility = Visibility.Visible;
            LblArticlesArticlesArticles.Visibility = Visibility.Visible;
            LblArticlesArticlesFamilles.Visibility = Visibility.Visible;
            LblArticlesArticlesSFamilles.Visibility = Visibility.Visible;
            LblArticlesArticlesStatistiques.Visibility = Visibility.Visible;
            LblArticlesArticlesHistoriquesClients.Visibility = Visibility.Visible;
            LblArticlesArticlesHistoriquesFournisseurs.Visibility = Visibility.Visible;

            LblArticlesTarifsClients.Visibility = Visibility.Visible;
            LblArticlesTarifsClientsTarifsClients.Visibility = Visibility.Visible;
            LblArticlesTarifsClientsCategories.Visibility = Visibility.Visible;

            LblArticlesTarifsFournisseurs.Visibility = Visibility.Visible;
            LblArticlesTarifsFournisseursTarifsFournisseurs.Visibility = Visibility.Visible;
            LblArticlesTarifsFournisseursCategories.Visibility = Visibility.Visible;
        }

        private void MenuItem_HideAll()
        {
            /* Couleur de fond originale de tous les boutons */
            BtnVentes.ClearValue(Button.BackgroundProperty);
            BtnReglements.ClearValue(Button.BackgroundProperty);
            BtnAchats.ClearValue(Button.BackgroundProperty);
            BtnArticles.ClearValue(Button.BackgroundProperty);

            /* Ventes */
            LblVentesDocuments.Visibility = Visibility.Collapsed;
            LblVentesDocumentsDevis.Visibility = Visibility.Collapsed;
            LblVentesDocumentsCommandes.Visibility = Visibility.Collapsed;
            LblVentesDocumentsFactures.Visibility = Visibility.Collapsed;
            LblVentesDocumentsReglements.Visibility = Visibility.Collapsed;
            LblVentesDocumentsTickets.Visibility = Visibility.Collapsed;

            LblVentesClients.Visibility = Visibility.Collapsed;
            LblVentesClientsProspects.Visibility = Visibility.Collapsed;
            LblVentesClientsClients.Visibility = Visibility.Collapsed;
            LblVentesClientsContacts.Visibility = Visibility.Collapsed;
            LblVentesClientsFamilles.Visibility = Visibility.Collapsed;
            LblVentesClientsSFamilles.Visibility = Visibility.Collapsed;
            LblVentesClientsHistorique.Visibility = Visibility.Collapsed;
            LblVentesClientsStatistiques.Visibility = Visibility.Collapsed;

            LblVentesReglements.Visibility = Visibility.Collapsed;
            LblVentesReglementsEcheancier.Visibility = Visibility.Collapsed;
            LblVentesReglementsReglements.Visibility = Visibility.Collapsed;

            /* Règlements */
            LblReglementsClients.Visibility = Visibility.Collapsed;
            LblReglementsClientsEcheancier.Visibility = Visibility.Collapsed;
            LblReglementsClientsReglements.Visibility = Visibility.Collapsed;
            LblReglementsFournisseurs.Visibility = Visibility.Collapsed;
            LblReglementsFournisseursEcheancier.Visibility = Visibility.Collapsed;
            LblReglementsFournisseursReglements.Visibility = Visibility.Collapsed;

            /* Achats */
            LblAchatsDocuments.Visibility = Visibility.Collapsed;
            LblAchatsDocumentsDemandes.Visibility = Visibility.Collapsed;
            LblAchatsDocumentsCommandes.Visibility = Visibility.Collapsed;
            LblAchatsDocumentsReception.Visibility = Visibility.Collapsed;
            LblAchatsDocumentsRetour.Visibility = Visibility.Collapsed;
            LblAchatsDocumentsFactures.Visibility = Visibility.Collapsed;
            LblAchatsDocumentsAvoirs.Visibility = Visibility.Collapsed;

            LblAchatsFournisseurs.Visibility = Visibility.Collapsed;
            LblAchatsFournisseursFournisseurs.Visibility = Visibility.Collapsed;
            LblAchatsFournisseursContacts.Visibility = Visibility.Collapsed;
            LblAchatsFournisseursFamilles.Visibility = Visibility.Collapsed;
            LblAchatsFournisseursSFamilles.Visibility = Visibility.Collapsed;
            LblAchatsFournisseursHistorique.Visibility = Visibility.Collapsed;
            LblAchatsFournisseursStatistiques.Visibility = Visibility.Collapsed;

            LblAchatsReglements.Visibility = Visibility.Collapsed;
            LblAchatsReglementsEcheancier.Visibility = Visibility.Collapsed;
            LblAchatsReglementsReglements.Visibility = Visibility.Collapsed;

            /* Stocks / Articles */
            LblArticlesDocuments.Visibility = Visibility.Collapsed;
            LblArticlesDocumentsEntrees.Visibility = Visibility.Collapsed;
            LblArticlesDocumentsSorties.Visibility = Visibility.Collapsed;
            LblArticlesDocumentsInventaires.Visibility = Visibility.Collapsed;

            LblArticlesArticles.Visibility = Visibility.Collapsed;
            LblArticlesArticlesArticles.Visibility = Visibility.Collapsed;
            LblArticlesArticlesFamilles.Visibility = Visibility.Collapsed;
            LblArticlesArticlesSFamilles.Visibility = Visibility.Collapsed;
            LblArticlesArticlesStatistiques.Visibility = Visibility.Collapsed;
            LblArticlesArticlesHistoriquesClients.Visibility = Visibility.Collapsed;
            LblArticlesArticlesHistoriquesFournisseurs.Visibility = Visibility.Collapsed;

            LblArticlesTarifsClients.Visibility = Visibility.Collapsed;
            LblArticlesTarifsClientsTarifsClients.Visibility = Visibility.Collapsed;
            LblArticlesTarifsClientsCategories.Visibility = Visibility.Collapsed;

            LblArticlesTarifsFournisseurs.Visibility = Visibility.Collapsed;
            LblArticlesTarifsFournisseursTarifsFournisseurs.Visibility = Visibility.Collapsed;
            LblArticlesTarifsFournisseursCategories.Visibility = Visibility.Collapsed;
        }

    }
}
