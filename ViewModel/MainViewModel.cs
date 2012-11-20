using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GroupedItemsWithMvvmLight.Model;

namespace GroupedItemsWithMvvmLight.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /* These values were created by MvvmLight */
        public const string WelcomeTitlePropertyName = "WelcomeTitle";
        private string _welcomeTitle = string.Empty;

        private IEnumerable<ProductGroup> _products;

        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                if (_welcomeTitle == value)
                {
                    return;
                }

                _welcomeTitle = value;
                RaisePropertyChanged(WelcomeTitlePropertyName);
            }
        }

        public IEnumerable<ProductGroup> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                RaisePropertyChanged(()=>Products);
            }
        }

        public MainViewModel()
        {
            WelcomeTitle = "Welcome";

            if (IsInDesignMode)
            {
                BuildProducts();
            }
            // Build non design collection
            BuildProducts();
        }


        private void BuildProducts()
        {
            ProductGroup tv = new ProductGroup("TV");
            tv.Items = new ObservableCollection<ProductItem>
                           {

                               new ProductItem
                                   {
                                       Title = "Sony bravia",
                                       Price = 800,
                                       ImagePath = "Assets/Tv/sony.jpg"
                                   },
                               new ProductItem
                                   {
                                       Title = "Samsung",
                                       Price = 800,
                                       ImagePath = "Assets/Tv/samsung.jpg"
                                   },
                               new ProductItem
                                   {
                                       Title = "LG",
                                       Price = 750,
                                       ImagePath = "Assets/Tv/lg.jpg"
                                   },
                               new ProductItem
                                   {
                                       Title = "Sharp",
                                       Price = 500,
                                       ImagePath = "Assets/Tv/sharp.jpg"
                                   },
                               new ProductItem
                                   {
                                       Title = "Philips",
                                       Price = 630,
                                       ImagePath = "Assets/Tv/philips.jpg"
                                   },
                               new ProductItem
                                   {
                                       Title = "Linsar",
                                       Price = 300,
                                       ImagePath = "Assets/Tv/linsar.jpg"
                                   }
                           };

            ProductGroup phone = new ProductGroup("Phone");
            phone.Items = new ObservableCollection<ProductItem>
                              {
                                  new ProductItem
                                      {
                                          Title = "Nokia Lumia 920",
                                          Price = 450,
                                          ImagePath = "Assets/Phone/nokia.jpg"
                                      },
                                  new ProductItem
                                      {
                                          Title = "LG Optimus",
                                          Price = 320,
                                          ImagePath = "Assets/Phone/lg.jpg"
                                      },
                                  new ProductItem
                                      {
                                          Title = "Samsung Galaxy",
                                          Price = 380,
                                          ImagePath = "Assets/Phone/samsung.jpg"
                                      },
                                  new ProductItem
                                      {
                                          Title = "BlackBerry",
                                          Price = 280,
                                          ImagePath = "Assets/Phone/blackberry.jpg"
                                      },
                                  new ProductItem
                                      {
                                          Title = "HTC X8",
                                          Price = 400,
                                          ImagePath = "Assets/Phone/htc.jpg"
                                      }
                              };

            _products = new List<ProductGroup> {tv, phone};
        }

    }
}