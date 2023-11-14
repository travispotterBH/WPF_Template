using System.Windows;
using System.Windows.Input;
using WPF_Template.Interface;

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

        public ICommand CopyCommand { get; set; }

        /***************************************************/
        /****                Constructor                ****/
        /***************************************************/

        public ContextMenuWindowViewModel()
        {
            SetupBaseCommands();
            Text_1 = "Menu 1";
            Text_2 = "Menu 2";
            Text_3 = "Menu 3";
            CopyCommand = new RouteCommands(Copy, o => true);
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

        private void Copy(object parameter)
        {
            MessageBox.Show(parameter.ToString());
        }

        /***************************************************/

    }
}
