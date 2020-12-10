using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model
{
	public class TicketItem
	{
		public int Id { get; private set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
	}
}
