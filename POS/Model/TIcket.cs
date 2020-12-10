using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model
{
	public class TIcket
	{
		public int Id { get; private set; }
		public int TicketNumber { get; set; }
		public Customer Customer { get; set; }
		public DateTimeOffset? DropDate { get; set; }
		public DateTimeOffset PickupDate { get; set; }
	}
}
