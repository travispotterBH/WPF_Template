using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Template.Models;
using WPF_Template.ViewModels;

namespace WPF_Template.Views
{
    public partial class ContextMenuWindowView : Window
    {
        /***************************************************/
        /****               Private fields              ****/
        /***************************************************/

        private ContextMenuWindowViewModel m_ContextMenuWindowViewModel;

        public ContextMenuWindowViewModel ContextMenuWindowViewModel
        {
            get { return m_ContextMenuWindowViewModel; }
            set { m_ContextMenuWindowViewModel = value; }
        }


        /***************************************************/
        /****               Constructors                ****/
        /***************************************************/

        public ContextMenuWindowView(ContextMenuWindowViewModel contextMenuWindowViewModel)
        {
            InitializeComponent();
            this.DataContext = m_ContextMenuWindowViewModel = contextMenuWindowViewModel;
            InitializeActions();
        }


        /***************************************************/
        /****             Private Methods               ****/
        /***************************************************/

        private void InitializeActions()
        {
            //On setup of mainwindow, view model is passed an action to close this window
            if (m_ContextMenuWindowViewModel.ExecutionFinishedAction == null)
                m_ContextMenuWindowViewModel.ExecutionFinishedAction = new Action(() => this.Close());

            if (m_ContextMenuWindowViewModel.ExecutionFinishedAction == null)
                m_ContextMenuWindowViewModel.ExecutionFinishedAction = new Action(() => this.Close());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var parentViewModel = ((ContextMenuWindowViewModel)this.DataContext).ParentViewModel as MainWindowViewModel;
            parentViewModel.ContextMenuWindowViewModel = (ContextMenuWindowViewModel)this.DataContext;

        }
        private void CopyText(object parameter)
        {
            if (parameter is string textToCopy)
            {
                Clipboard.SetText(textToCopy);
            }
        }

        private void MenuCopyItem_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null && menuItem.Tag != null)
            {
                var text = menuItem.Tag.ToString();
                CopyText(text);
            }
        }

    }
}
