using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Template.Interface;

namespace WPF_Template.Models
{
    public class MainWindowModel : IModel
    {
        public NestedWindowModel NestedWindowModel { get; set; } = null;
        public CollectionsWindowModel CollectionsWindowModel { get; set; } = null;
    }
}
