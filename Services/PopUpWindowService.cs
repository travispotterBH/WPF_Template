using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Template.Interface;

namespace WPF_Template.Services
{
    public static class PopUpWindowService
    {
        public static bool? ShowWindowAsDialog(Window window, Window owner)
        {
            window.Owner = owner;

            bool? result = window.ShowDialog();
            return result ?? null;
        }
    }
}
