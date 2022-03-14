using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
namespace ApplicationDemo
{
    /// <summary>
    /// Logique d'interaction pour DetailsArticles.xaml
    /// </summary>
    public partial class DetailsArticles : Window
    {
        //instanciation du contexte
        BloggingContext context = new BloggingContext();
        public DetailsArticles()
        {
            InitializeComponent();


            //remplissage du datagrid
            DataGridDetails.ItemsSource = context.Posts.ToList();
        }

        private void BoutonAccueil_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            //fermeture de la fénétre courante
            this.Close();
        }
    }
}
