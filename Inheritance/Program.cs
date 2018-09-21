using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Program {
		static void Main(string[] args) {

			Employee e1 = new Employee();
			e1.Name = "E1";
			e1.Position = "Flunky";
			e1.Salary = 5999;
			e1.VacationDays = 0;
			//e1.Print();

			Employee e2 = new Employee();

			Manager m1 = new Manager();
			m1.Name = "M1";
			m1.Position = "Supervisor";
			m1.Salary = 5998;
			m1.VacationDays = 1;
			m1.PurchaseAuth = 10.99M;
			//m1.Print();

			e1.Manager = m1;

			Administrator a1 = new Administrator();
			a1.AssignedTo = m1;
			a1.Manager = m1;
			

			List<Employee> employees = new List<Employee>();
			employees.Add(e1);
			employees.Add(m1);
			employees.Add(a1);

			foreach(Employee employee in employees) {
				string msg = employee.Print();
				Console.WriteLine(msg);
			}

		}
	}
}
