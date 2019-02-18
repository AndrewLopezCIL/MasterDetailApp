using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter __productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //
            __productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());
       

        //
        // instantiate, set the data context, and show the Main window
        //
        _productWindowView = new ProductWindowView(__productWindowPresenter);
        _productWindowView.DataContext = __productWindowPresenter;
        _productWindowView.Show();
        }

        #endregion

        #region METHODS

        private Product GetProductData()
        {
            return new Product()
            {
                _GameTitle = "Fortnite",
                _CompanyName = "Epic Games",
                _GameDescription = "A Battle Royale game that you can play with your friends!",
                _GamePrice = 0.00,
                _GameReleaseDate = DateTime.Parse("07-25-2017"),
                _PlayerAmount = 125000000,
                ImageFileName = "fortnite.jpg"


            };

        }
            private Company GetCompanyData()
        {
            Company company = new Company();
            company.Name = "Game Company Finder";
            company.Address = "11 Front Street";
            company.City = "Traverse City";
            return company;
        }

        #endregion

        #region EVENTS


        #endregion

    }
}
