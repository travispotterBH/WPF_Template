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
    public partial class NestedWindowView : Window
    {
        /***************************************************/
        /****               Private fields              ****/
        /***************************************************/

        private NestedWindowViewModel m_NestedWindowViewModel;

        public NestedWindowViewModel NestedWindowViewModel
        {
            get { return m_NestedWindowViewModel; }
            set { m_NestedWindowViewModel = value; }
        }


        /***************************************************/
        /****               Constructors                ****/
        /***************************************************/

        public NestedWindowView(NestedWindowViewModel nestedWindowViewModel)
        {
            InitializeComponent();
            this.DataContext = m_NestedWindowViewModel = nestedWindowViewModel;
            InitializeActions();
        }


        /***************************************************/
        /****             Private Methods               ****/
        /***************************************************/

        private void InitializeActions()
        {
            //On setup of mainwindow, view model is passed an action to close this window
            if (m_NestedWindowViewModel.ExecutionFinishedAction == null)
                m_NestedWindowViewModel.ExecutionFinishedAction = new Action(() => this.Close());

            if (m_NestedWindowViewModel.ExecutionFinishedAction == null)
                m_NestedWindowViewModel.ExecutionFinishedAction = new Action(() => this.Close());

            //On setup of mainwindow, view model is passed an action to post an alert.
            if (m_NestedWindowViewModel.AlertAction == null)
                m_NestedWindowViewModel.AlertAction = new Action(() => AlertAction());
        }

        /***************************************************/

        private void AlertAction()
        {
            MessageBox.Show("Alert!");
        }

        /***************************************************/
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var parentViewModel = ((NestedWindowViewModel)this.DataContext).ParentViewModel as MainWindowViewModel;
            parentViewModel.NestedWindowViewModel = (NestedWindowViewModel)this.DataContext;

        }
    }
}
