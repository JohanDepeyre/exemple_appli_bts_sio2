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

namespace ApplicationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Redirection vers la page AjouterArticle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoutonPageDetails_Click(object sender, RoutedEventArgs e)
        {

            DetailsArticles detailsArticles = new DetailsArticles();
            detailsArticles.Show();
            this.Close();
        }

        private void BoutonAjouterPose_Click(object sender, RoutedEventArgs e)
        {
            AjouterArticle ajouterArticle = new AjouterArticle();
            ajouterArticle.Show();
            this.Close();
        }
    }
}
