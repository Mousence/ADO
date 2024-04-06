using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace library2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"Library PD_321\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			Library library = new Library(connection_string);
			library.InsertAuthor("Abercrombie", "Joe");
			//library.SelectAuthors();
			library.SelectBooks("James Cameron");
			library.InsertBook(int, string, int, decimal);
		}
	}
}
