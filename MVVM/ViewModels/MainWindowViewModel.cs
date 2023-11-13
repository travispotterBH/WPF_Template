using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_Template.Interface;
using WPF_Template.Models;
using WPF_Template.Services;
using WPF_Template.Views;

namespace WPF_Template.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {

        /***************************************************/
        private MainWindowModel m_MainWindowModel;
        public MainWindowModel MainWindowModel
        {
            get { return m_MainWindowModel; }
            set { m_MainWindowModel = value; }
        }

        /***************************************************/
        public Window OwnerWindow { get; set; }

        /***************************************************/

        private NestedWindowViewModel m_NestedWindowViewModel;

        public NestedWindowViewModel NestedWindowViewModel
        {
            get { return m_NestedWindowViewModel; }
            set { m_NestedWindowViewModel = value; }
        }

        /***************************************************/

        private CollectionsWindowViewModel m_CollectionsWindowViewModel;

        public CollectionsWindowViewModel CollectionsWindowViewModel
        {
            get { return m_CollectionsWindowViewModel; }
            set { m_CollectionsWindowViewModel = value; }
        }

        /***************************************************/

        /***************************************************/
        /****              Actions                      ****/
        /***************************************************/
        public Action AlertAction { get; set; }

        /***************************************************/
        /****              Commands                     ****/
        /***************************************************/

        public ICommand NestedWindowCommand { get; set; }
        public ICommand CollectionsWindowCommand { get; set; }
        public ICommand ContextMenuWindowCommand { get; set; }
        public ICommand PopUpWindowCommand { get; set; }
        public ICommand OpenFileCommand { get; set; }
        public ICommand SaveFileCommand { get; set; }
        public ICommand ImportCommand { get; set; }
        public ICommand ExportCommand { get; set; }



        /***************************************************/
        /****                Constructor                ****/
        /***************************************************/

        public MainWindowViewModel(MainWindowModel mainWindowModel = null)
        {
            m_MainWindowModel = mainWindowModel ?? new MainWindowModel();
            CancelCommand = new RouteCommands(CancelCommandAction);
            OkCommand = new RouteCommands(OkCommandAction);
            NestedWindowCommand = new RouteCommands(ShowNestedWindow);
            CollectionsWindowCommand = new RouteCommands(ShowCollectionsWindow);
            ContextMenuWindowCommand = new RouteCommands(ShowContextMenuWindow);
            PopUpWindowCommand = new RouteCommands(ShowPopUpWindow);
            OpenFileCommand = new RouteCommands(OpenFile);
            SaveFileCommand = new RouteCommands(SaveFile);
            ImportCommand = new RouteCommands(ImportAction);
            ExportCommand = new RouteCommands(ExportAction);

            Memento = this.FromViewModel();
        }


        /***************************************************/
        /****             Private Methods               ****/
        /***************************************************/
        private void ShowNestedWindow()
        {
            var nestedWindowViewModel = m_MainWindowModel.NestedWindowModel?.ToViewModel() ?? new NestedWindowViewModel(new NestedWindowModel());
            var nestedWindow = new NestedWindowView(nestedWindowViewModel);
            NestedWindowService.ShowWindowAsDialog(nestedWindow, OwnerWindow, this);
            m_MainWindowModel.NestedWindowModel = nestedWindowViewModel.FromViewModel();
        }

        public void ShowPopUpWindow()
        {
            var simplePopUpWindow = new SimplePopUpWindow("Did you see this pop up?");
            var value = PopUpWindowService.ShowWindowAsDialog(simplePopUpWindow, OwnerWindow);
        }
        private void ShowCollectionsWindow()
        {
            var collectionsWindowViewModel = m_MainWindowModel.CollectionsWindowModel?.ToViewModel() ?? new CollectionsWindowViewModel(new CollectionsWindowModel());
            var collectionsWindow = new CollectionsWindowView(collectionsWindowViewModel);
            NestedWindowService.ShowWindowAsDialog(collectionsWindow, OwnerWindow, this);
            m_MainWindowModel.CollectionsWindowModel = m_CollectionsWindowViewModel.FromViewModel();
        }

        private void ShowContextMenuWindow()
        {
            var contextMenuWindowViewModel = new ContextMenuWindowViewModel();
            var contextMenuWindow = new ContextMenuWindowView(contextMenuWindowViewModel);
            NestedWindowService.ShowWindowAsDialog(contextMenuWindow, OwnerWindow, this);
        }

        private void OpenFile()
        {
            var value = FileDialogService.OpenFileDialog("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
            //use file path to do something
        }

        private void SaveFile()
        {
            var value = FileDialogService.SaveFileDialog("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
            //use file path to do something
        }

        private void ImportAction()
        {
            var value = FileDialogService.OpenFileDialog("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
            //use file path to do something
        }

        private void ExportAction()
        {
            var value = FileDialogService.SaveFileDialog("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
            //use file path to do something
        }

        /***************************************************/
        internal override void OkCommandAction()
        {

            bool alertIsNeeded = false;
            if (alertIsNeeded)
            {
                AlertAction();
                return;
            }

            //UpdateSettings(this);
            ExecutionFinishedAction();
        }

        /***************************************************/

        internal override void CancelCommandAction()
        {
            //UpdateSettings((Memento as MainWindowModel).ToViewModel());
            ExecutionFinishedAction();
        }

        /***************************************************/
    }

}
