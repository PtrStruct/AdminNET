using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminNET.Core;
using AdminNET.MVVM.View;
using AdminNET.Properties;

namespace AdminNET.MVVM.ViewModel
{
    class BaseViewModel : ObservableObject
    {

        public RelayCommand SettingsCommand { get; set; }

        public BaseViewModel()
        {
            SettingsCommand = new RelayCommand(o =>
            {
                SettingsWindowView SWV = new SettingsWindowView();
                SWV.Show();
            }, o => true);

            CatalogViewModel = new CatalogViewModel();
            CurrentView = CatalogViewModel;
        }

        private CatalogViewModel _catalogViewModel;

        public CatalogViewModel CatalogViewModel
        {
            get { return _catalogViewModel; }
            set { _catalogViewModel = value; }
        }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

    }
}
