using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carsharing_project
{
	public class Service
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Price { get; set; }
		public string Count { get; set; }

		public Service(string name, string description, string price, string count)
		{
			Name = name;
			Description = description;
			Price = price;
			Count = count;
		}
	}

	public class ServiceList
	{
		public List<Service> services { get; set; }
	}
}
