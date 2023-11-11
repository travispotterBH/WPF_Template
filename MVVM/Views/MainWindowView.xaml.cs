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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Template.Models;
using WPF_Template.ViewModels;

namespace WPF_Template
{
    public partial class MainWindowView : Window
    {

        /***************************************************/
        /****               Private fields              ****/
        /***************************************************/

        private MainWindowViewModel m_ViewModel;

        /***************************************************/
        /****               Constructors                ****/
        /***************************************************/

        public MainWindowView()
        {
            var mainWindowViewModel = Mocks.Mocks.mainWindowModel.ToViewModel();
            InitializeComponent();
            this.DataContext = m_ViewModel = mainWindowViewModel;
            m_ViewModel.OwnerWindow = this;
            InitializeActions();
        }


        /***************************************************/
        /****             Private Methods               ****/
        /***************************************************/

        private void InitializeActions()
        {
            //On setup of mainwindow, view model is passed an action to close this window
            if (m_ViewModel.ExecutionFinishedAction == null)
                m_ViewModel.ExecutionFinishedAction = new Action(() => this.Close());

            //On setup of mainwindow, view model is passed an action to post an alert.
            if (m_ViewModel.AlertAction == null)
                m_ViewModel.AlertAction = new Action(() => AlertAction());
        }

        /***************************************************/

        private void AlertAction()
        {
            MessageBox.Show("Alert!");
        }

        /***************************************************/
    }

}
