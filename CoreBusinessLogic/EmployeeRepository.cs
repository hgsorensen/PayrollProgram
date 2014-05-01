using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusinessLogic
{
	public abstract class EmployeeRepository
	{
		public abstract IEnumerable<Employee> GetEmployees();
	}
}
