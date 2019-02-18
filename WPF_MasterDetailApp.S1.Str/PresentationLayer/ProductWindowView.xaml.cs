using WPF_MasterDetailApp.Models;
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

namespace WPF_MasterDetailApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ProductWindowView : Window
    {
        #region FIELDS

        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region METHODS (pass events to view model)

        private void Button_Quit_Click(object sender, RoutedEventArgs e)
        {
            _productWindowPresenter.QuitApplication();
        }
        
        #endregion

        #region CONSTRUCTORS

        public ProductWindowView(ProductWindowPresenter productPresenter)
        {
            _productWindowPresenter = productPresenter;

            DataContext = _productWindowPresenter;

            InitializeComponent();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow();
            add.Show();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            txtCompany.Text = "Epic Games";
            txtGameDescription.Text = "A Battle Royale Game.";
            txtGameTitle.Text = "Fortnite";
            txtPlayerBaseSize.Text = "125,000,000";
            txtPriceOfGame.Text = "Free";
            txtReleaseDate.Text = "07/25/2017";
        }
         
    }
}
