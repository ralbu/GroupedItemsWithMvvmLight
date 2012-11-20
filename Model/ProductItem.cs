using System;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace GroupedItemsWithMvvmLight.Model
{
    public class ProductItem
    {
        private readonly Uri _baseUri = new Uri("ms-appx:///");
        private ImageSource _image;

        public string Title { get; set; }
        public int Price { get; set; }

        public ImageSource Image 
        {
            get
            {
                if (_image == null && ImagePath != null)
                {
                    _image = new BitmapImage(new Uri(_baseUri, ImagePath));
                }

                return _image;
            }
        }
        public string ImagePath { get; set; }

    }
}
