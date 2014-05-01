using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CoreBusinessLogic;

namespace CoreBusinessLogic.Test
{
	public class TestEmployeeRepository : EmployeeRepository
	{
		private readonly TestEmployee employee;

		public TestEmployeeRepository()
			: this(new TestEmployee())
		{
		}

		public TestEmployeeRepository(TestEmployee employee)
		{
			this.employee = employee;
		}

		public Boolean GaveEmployees { get; set; }
		public override IEnumerable<Employee> GetEmployees()
		{
			GaveEmployees = true;
			return new List<Employee> {employee};
		}
	}
}
