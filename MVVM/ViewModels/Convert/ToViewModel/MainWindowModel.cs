using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_Template.Models;
using WPF_Template.Services;

namespace WPF_Template.ViewModels
{
    public static partial class Convert
    {
        public static MainWindowViewModel ToViewModel(this MainWindowModel mainWindowModel)
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel(mainWindowModel)
            {

            };

            return mainWindowViewModel;
        }
    }
}
