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
        }

        private void MenuItem_Achats(object sender, RoutedEventArgs e)
        {
            MenuItem_HideAll();
            LblAchatsFournisseurs.Visibility = Visibility.Visible;
            LblAchatsFactures.Visibility = Visibility.Visible;
            LblAchatsReglements.Visibility = Visibility.Visible;
        }

        private void MenuItem_Reglements(object sender, RoutedEventArgs e)
        {
            MenuItem_HideAll();
            LblReglementsClients.Visibility = Visibility.Visible;
            LblReglementsClientsEcheancier.Visibility = Visibility.Visible;
        }

        private void MenuItem_Stocks(object sender, RoutedEventArgs e)
        {
            MenuItem_HideAll();
        }

        private void MenuItem_HideAll()
        {
            /* Couleur de fond originale de tous les boutons */
            BtnVentes.ClearValue(Button.BackgroundProperty);
            BtnReglements.ClearValue(Button.BackgroundProperty);
            BtnAchats.ClearValue(Button.BackgroundProperty);
            BtnArticles.ClearValue(Button.BackgroundProperty);

            LblVentesDocuments.Visibility = Visibility.Collapsed;
            LblVentesDocumentsDevis.Visibility = Visibility.Collapsed;
            LblVentesDocumentsCommandes.Visibility = Visibility.Collapsed;
            LblVentesDocumentsFactures.Visibility = Visibility.Collapsed;
            LblVentesDocumentsReglements.Visibility = Visibility.Collapsed;
            LblVentesDocumentsTickets.Visibility = Visibility.Collapsed;
            LblVentesClients.Visibility = Visibility.Collapsed;

            LblReglementsClients.Visibility = Visibility.Collapsed;
            LblReglementsClientsEcheancier.Visibility = Visibility.Collapsed;
            LblReglementsClientsReglements.Visibility = Visibility.Collapsed;
            LblReglementsFournisseurs.Visibility = Visibility.Collapsed;
            LblReglementsFournisseursEcheancier.Visibility = Visibility.Collapsed;
            LblReglementsFournisseursReglements.Visibility = Visibility.Collapsed;

            LblAchatsFactures.Visibility = Visibility.Collapsed;
            LblAchatsFournisseurs.Visibility = Visibility.Collapsed;
            LblAchatsReglements.Visibility = Visibility.Collapsed;

            LblArticlesArticles.Visibility = Visibility.Collapsed;
            LblArticlesEntrees.Visibility = Visibility.Collapsed;
        }

    }
}
