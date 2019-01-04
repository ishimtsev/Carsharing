using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace carsharing_project
{
	static class Connection
	{
		public static string str = "Server=localhost;Port=5432;User Id=postgres;Password=240398;Database=SUBD;";
		
		//public static NpgsqlConnection con = new NpgsqlConnection(str);
	}
}
