using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminNET.Core;
using AdminNET.MVVM.Model;

namespace AdminNET.MVVM.ViewModel
{
    class CatalogViewModel : ObservableObject
    {
        public ObservableCollection<CatalogItem> CategoryItems { get; set; }
        public CatalogViewModel()
        {
            CategoryItems = new ObservableCollection<CatalogItem>();

            for (int i = 0; i < 12; i++)
            {
                CategoryItems.Add(new CatalogItem
                {
                    Title = "React",
                    Description = "A Powerful JS Library",
                    Icon = "https://jsonworld.com/content/uploads/blog-images/react.png"
                });
            }
        }
    }
}
