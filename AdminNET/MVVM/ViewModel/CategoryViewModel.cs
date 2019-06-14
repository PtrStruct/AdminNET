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
    class CategoryViewModel : ObservableObject
    {
        public ObservableCollection<CategoryItem> CategoryItems { get; set; }
        public CategoryViewModel()
        {
            CategoryItems = new ObservableCollection<CategoryItem>();

            for (int i = 0; i < 12; i++)
            {
                CategoryItems.Add(new CategoryItem
                {
                    Title = "React",
                    Description = "A Powerful JS Library",
                    Icon = "https://jsonworld.com/content/uploads/blog-images/react.png"
                });
            }
        }
    }
}
