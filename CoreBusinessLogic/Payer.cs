using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusinessLogic
{
    public abstract class Payer
	{
		private readonly EmployeeRepository employeeRepository;
		private readonly PaymentDispatcherFactory paymentDispatcherFactory;

	    protected Payer(EmployeeRepository employeeRepository, PaymentDispatcherFactory paymentDispatcherFactory)
		{
			this.employeeRepository = employeeRepository;
			this.paymentDispatcherFactory = paymentDispatcherFactory;
		}

	    public void CheckPay()
	    {
		    foreach (var employee in employeeRepository.GetEmployees())
		    {
			    if (employee.IsPayDay())
			    {
				    double pay = employee.CalculatePay();
				    var paymentDispatcher = paymentDispatcherFactory.Create(employee.PaymentMethod);
				    paymentDispatcher.TransferMoney(pay);
			    }
		    }
	    }
	}
}
