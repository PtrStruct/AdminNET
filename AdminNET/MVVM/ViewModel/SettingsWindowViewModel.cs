using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminNET.Services;

namespace AdminNET.MVVM.ViewModel
{
    class SettingsWindowViewModel
    {
        //Every time the "Settings Window" invokes, call "Initialize".
        public SettingsWindowViewModel()
        {
            SettingsService.Initialize();
        }
    }
}
