using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model
{
	public class Customer
	{
		public int Id { get; private set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName => FirstName + " " + LastName;
		public string PhoneNumber { get; set; }
	}
}
