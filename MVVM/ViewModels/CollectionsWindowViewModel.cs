using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Template.Interface;
using WPF_Template.Models;

namespace WPF_Template.ViewModels
{
    public class CollectionsWindowViewModel : ViewModel
    {
        /***************************************************/
        /****               Private fields              ****/
        /***************************************************/
        private ObservableCollection<Employee> m_employees;

        public ObservableCollection<Employee> Employees
        {
            get { return m_employees; }
            set { SetProperty(ref m_employees, value); }
        }

        /***************************************************/
        /****              Public properties            ****/
        /***************************************************/


        /***************************************************/
        /****              Actions                      ****/
        /***************************************************/


        /***************************************************/
        /****              Commands                     ****/
        /***************************************************/
        public ICommand AddEmployeeCommand { get; set; }

        /***************************************************/
        /****                Constructor                ****/
        /***************************************************/

        public CollectionsWindowViewModel(CollectionsWindowModel collectionsWindowModel)
        {
            SetupBaseCommands();
            AddEmployeeCommand = new RouteCommands(new Action(AddEmployeeAction));
            Setup(collectionsWindowModel);
            Memento = this.FromViewModel();
        }


        private void AddEmployeeAction()
        {
            Employees.Add(new Employee() { FirstName = "Emp", LastName = "Loyee", Id = 10 });
        }

        /***************************************************/
        /****             Private Methods               ****/
        /***************************************************/

        internal override void OkCommandAction()
        {
            (ParentViewModel as MainWindowViewModel).CollectionsWindowViewModel = this;
            ExecutionFinishedAction();
        }

        /***************************************************/

        internal override void CancelCommandAction()
        {
            (ParentViewModel as MainWindowViewModel).CollectionsWindowViewModel = (Memento as CollectionsWindowModel).ToViewModel();
            ExecutionFinishedAction();
        }

        /***************************************************/
        public void Setup(IModel collectionsWindowModel)
        {
            Employees = new ObservableCollection<Employee>((collectionsWindowModel as CollectionsWindowModel).Employees);
        }
    }
}
