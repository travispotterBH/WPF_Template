using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Template.Models;

namespace WPF_Template.Mocks
{
    public static class Mocks
    {
        public static List<Employee> EmployeeList = new List<Employee>()
        {
            new Employee(){FirstName="Bhomas", LastName="Softwareman", Id=1 },
            new Employee(){FirstName="Ryan", LastName="O'Grasshopper", Id=2 },
            new Employee(){FirstName="Excelandra", LastName="Calculatin", Id=3 },
            new Employee(){FirstName="Revita", LastName="Autodeski", Id=4 },
        };

        public static MainWindowModel mainWindowModel = new MainWindowModel()
        {
            NestedWindowModel = new NestedWindowModel(),
            CollectionsWindowModel = new CollectionsWindowModel()
            {
                Employees = EmployeeList,
            },
        };
    }
}
