using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminNET.MVVM.Model
{
    class SettingsModel
    {
        private string _os;

        public string OperatingSystem
        {
            get { return _os; }
            set { _os = value; }
        }

        private string _totalRAM;

        public string TotalRAM
        {
            get { return _totalRAM; }
            set { _totalRAM = value; }
        }



    }
}
