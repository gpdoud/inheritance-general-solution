using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Employee {

		private int EmployeeOnly = 0;

		public string Name { get; set; }
		public string Position { get; set; }
		public decimal Salary { get; set; }
		public Manager Manager { get; set; }
		public int VacationDays { get; set; }

		public virtual string Print() {
			return $"Name {Name} Salary {Salary} Position {Position}";
		}
	}
}
