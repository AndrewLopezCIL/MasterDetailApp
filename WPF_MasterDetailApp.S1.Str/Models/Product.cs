using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product 
    {
        #region ENUMS



        #endregion

        #region FIELDS

       private string companyName;
       private string gameTitle;
       private string gameDescription;
       private DateTime gameReleaseDate;
       private double gamePrice;
       private int playerAmount;
       private string imageFileName;
        #endregion

        #region PROPERTIES 

        public string _CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string _GameTitle
        {
            get { return gameTitle; }
            set { gameTitle = value; }
        }
        public string _GameDescription
        {
            get { return gameDescription; }
            set { gameDescription = value; }
        }
        public DateTime _GameReleaseDate
        {
            get { return gameReleaseDate; }
            set { gameReleaseDate = value; }
        }
         
        public int _PlayerAmount
        {
            get { return playerAmount; }
            set { playerAmount = value; }
        }

        public double _GamePrice
        {
            get { return gamePrice; }
            set { gamePrice = value; }
        }
        public string ImageFileName
        {
            get { return imageFileName; }
            set
            {
                imageFileName = value;
                imageFileName = @"../Images/" + imageFileName;
                //RaisePropertyChangedEvent("ImageFileName");
            }
        }



        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
