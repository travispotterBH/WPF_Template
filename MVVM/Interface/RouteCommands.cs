using System;
using System.Windows.Input;

namespace WPF_Template.Interface
{
    public class RouteCommands : ICommand
    {
        /***************************************************/
        /****                  Readonly                 ****/
        /***************************************************/

        private readonly Action<object> m_execute;

        private readonly Action<object> m_ActionWithParameter;
        private readonly Action m_ActionWithoutParameter;

        private readonly Predicate<object> m_canExecute;

        /***************************************************/
        /****               Public Methods              ****/
        /***************************************************/

        public RouteCommands(Action<object> mExecute, Predicate<object> mCanExecute)
        {
            if (mExecute == null)
                throw new NullReferenceException("execute");

            m_execute = mExecute;
            m_canExecute = mCanExecute;
        }

        /***************************************************/

        public RouteCommands(Action action)
        {
            m_ActionWithoutParameter = action;
        }
        public RouteCommands(Action<object> action)
        {
            m_ActionWithParameter = action;
        }
        /***************************************************/

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /***************************************************/

        public bool CanExecute(object parameter)
        {
            return m_canExecute == null ? true : m_canExecute(parameter);
        }

        /***************************************************/

        public void Execute(object parameter)
        {
            if (m_ActionWithoutParameter == null && m_ActionWithParameter == null)
                m_execute.Invoke(parameter);
            else if (m_ActionWithoutParameter != null)
                m_ActionWithoutParameter();
            else
                m_ActionWithParameter(parameter);
        }

        /***************************************************/
    }
}
