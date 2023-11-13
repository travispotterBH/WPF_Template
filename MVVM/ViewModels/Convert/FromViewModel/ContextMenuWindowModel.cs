using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_Template.Models;

namespace WPF_Template.ViewModels
{
    public static partial class Convert
    {
        public static ContextMenuWindowModel FromViewModel(this ContextMenuWindowViewModel contextMenuWindowViewModel)
        {
            ContextMenuWindowModel contextMenuWindowModel = new ContextMenuWindowModel()
            {

            };

            return contextMenuWindowModel;
        }
    }
}
