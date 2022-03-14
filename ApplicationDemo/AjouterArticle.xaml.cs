using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ApplicationDemo
{
    /// <summary>
    /// Logique d'interaction pour AjouterArticle.xaml
    /// </summary>
    public partial class AjouterArticle : Window
    {
        //instanciation du contexte
        BloggingContext context = new BloggingContext();

        /// <summary>
        /// Fonction d'initialisation de la page
        /// </summary>
        public AjouterArticle()
        {

            InitializeComponent();
        }

        private void BoutonAjouter_Click(object sender, RoutedEventArgs e)
        {

            if (TextBoxTitre.Text !="" && TextBoxContenu.Text != "")
            {
                context.Posts.Add(
                new Post { Title = TextBoxTitre.Text, Content = TextBoxContenu.Text });
            }
            //sauvegarde des data
            try
            {
                //sauvergarde
                context.SaveChanges();

                MessageBox.Show("Insertion reussi", "Succés", MessageBoxButton.OK, MessageBoxImage.Information);
             
                //recupération de l'exception si echec
            }catch (Exception ex)
            {
                //affiche un message d'érreur
                MessageBox.Show(ex.Message, "Echec", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            DetailsArticles detailsArticles = new DetailsArticles();
            detailsArticles.Show();
            this.Close();
        }
    }
}
