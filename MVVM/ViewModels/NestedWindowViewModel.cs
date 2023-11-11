using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Template.Interface;
using WPF_Template.Models;

namespace WPF_Template.ViewModels
{
    public class NestedWindowViewModel : ViewModel
    {

        /***************************************************/
        /****               Private fields              ****/
        /***************************************************/

        /***************************************************/
        /****              Public properties            ****/
        /***************************************************/


        /***************************************************/
        /****              Actions                      ****/
        /***************************************************/
        public Action AlertAction { get; set; }

        /***************************************************/
        /****              Commands                     ****/
        /***************************************************/

        /***************************************************/
        /****                Constructor                ****/
        /***************************************************/

        public NestedWindowViewModel(NestedWindowModel nestedWindowModel)
        {
            SetupBaseCommands();
        }

        /***************************************************/
        /****             Private Methods               ****/
        /***************************************************/
        internal override void OkCommandAction()
        {
            ExecutionFinishedAction();
        }

        /***************************************************/

        internal override void CancelCommandAction()
        {
            ExecutionFinishedAction();
        }

        /***************************************************/
    }

}
