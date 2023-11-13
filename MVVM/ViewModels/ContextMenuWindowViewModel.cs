using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Template.Interface;
using WPF_Template.Models;
using System.Windows;
using WPF_Template.Services;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace WPF_Template.ViewModels
{
    public class ContextMenuWindowViewModel : ViewModel
    {

        private string m_Text_1;

        public string Text_1
        {
            get { return m_Text_1; }
            set { SetProperty(ref m_Text_1, value); }
        }

        private string m_Text_2;

        public string Text_2
        {
            get { return m_Text_2; }
            set { SetProperty(ref m_Text_2, value); }
        }

        private string m_Text_3;

        public string Text_3
        {
            get { return m_Text_3; }
            set { SetProperty(ref m_Text_3, value); }
        }
        /***************************************************/
        /****               Private fields              ****/
        /***************************************************/

        /***************************************************/
        /****              Public properties            ****/
        /***************************************************/

        /***************************************************/
        /****              Actions                      ****/
        /***************************************************/

        /***************************************************/
        /****              Commands                     ****/
        /***************************************************/

        /***************************************************/
        /****                Constructor                ****/
        /***************************************************/

        public ContextMenuWindowViewModel()
        {
            SetupBaseCommands();
            Text_1 = "Menu 1";
            Text_2 = "Menu 2";
            Text_3 = "Menu 3";
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
