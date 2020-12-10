using POS.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace POS.ViewModel
{
	public class CustomerViewModel:ViewModelBase
	{
		//Need to initialize Customers collection 
		public CustomerViewModel()
		{
			Customers = new ObservableCollection<Customer>();
		}
		//List of Customers that the CustomerView will bind to 
		public ObservableCollection<Customer> Customers { get; set; }

		//Need to implement a way to load customers into Customers 
		//For now hard-code it for the sake of getting the application to work but later on move it out 
		public void LoadCustomers()
		{
			ObservableCollection<Customer> customers = new ObservableCollection<Customer>()
			{
				new Customer(){FirstName = "Heui", LastName="Park", PhoneNumber="5203969284"},
				new Customer(){FirstName = "Eun", LastName="Park", PhoneNumber="5204149925"},
				new Customer(){FirstName = "Jeong", LastName="Lee", PhoneNumber="5209010952"}
			};
		}
	}
}
