using System.Collections.ObjectModel;

namespace GroupedItemsWithMvvmLight.Model
{
    public class ProductGroup
    {
        public ProductGroup(string title)
        {
            Title = title;
            Items = new ObservableCollection<ProductItem>();
        }

        public string Title { get; set; }

        public ObservableCollection<ProductItem> Items { get; set; }
    }
}
