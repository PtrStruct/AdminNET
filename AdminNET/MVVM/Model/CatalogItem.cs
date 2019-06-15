using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminNET.MVVM.Model
{
    class CatalogItem
    {
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _icon;

        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        private bool _installed;

        public bool Installed
        {
            get { return _installed; }
            set { _installed = value; }
        }

    }
}
