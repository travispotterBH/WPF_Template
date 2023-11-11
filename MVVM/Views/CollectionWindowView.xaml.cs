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
    public partial class CollectionsWindowView : Window
    {
        /***************************************************/
        /****               Private fields              ****/
        /***************************************************/

        private CollectionsWindowViewModel m_CollectionsWindowViewModel;

        public CollectionsWindowViewModel CollectionWindowViewModel
        {
            get { return m_CollectionsWindowViewModel; }
            set { m_CollectionsWindowViewModel = value; }
        }


        /***************************************************/
        /****               Constructors                ****/
        /***************************************************/

        public CollectionsWindowView(CollectionsWindowViewModel collectionsWindowViewModel)
        {
            InitializeComponent();
            this.DataContext = m_CollectionsWindowViewModel = collectionsWindowViewModel; 
            InitializeActions();
        }


        /***************************************************/
        /****             Private Methods               ****/
        /***************************************************/

        private void InitializeActions()
        {
            //On setup of mainwindow, view model is passed an action to close this window
            if (m_CollectionsWindowViewModel.ExecutionFinishedAction == null)
                m_CollectionsWindowViewModel.ExecutionFinishedAction = new Action(() => this.Close());

            if (m_CollectionsWindowViewModel.ExecutionFinishedAction == null)
                m_CollectionsWindowViewModel.ExecutionFinishedAction = new Action(() => this.Close());
        }

        /***************************************************/
    }
}
