using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Configuration; // для App.config

namespace library2
{
	internal class Library
	{
		string connection_string;
		SqlConnection connection;
		public SqlCommand cmd { get; set; }
		public Library():this(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString) {
            Console.WriteLine(connection_string);
        }
		public Library(string connection_string) {
			this.connection_string = connection_string;
			connection = new SqlConnection(connection_string);
		}
		~Library() => connection.Close();
		public void InsertAuthor(string last_name, string first_name)
		{
			try 
			{
				connection.Open();
				string command = $@"
				IF NOT EXISTS (SELECT author_id FROM Authors WHERE last_name = @paramLastName AND first_name = @paramFirstName) 
				BEGIN	
						INSERT INTO Authors(last_name, first_name)
						VALUES (@paramLastName, @paramFirstName)
				END";
				cmd = new SqlCommand(command, connection);

				//				params

				//SqlParameter sqlParameterLastName = new SqlParameter("paramLastName", SqlDbType.NVarChar);
				//SqlParameter sqlParameterFirstName = new SqlParameter("paramFirstName", SqlDbType.NVarChar);
				//sqlParameterLastName.Value = last_name;
				//sqlParameterFirstName.Value = first_name;
				//cmd.Parameters.Add(sqlParameterLastName);
				//cmd.Parameters.Add(sqlParameterFirstName);

				//SqlParameter[] values = new SqlParameter[]
				//{
				//	new SqlParameter("paramLastName", last_name),
				//	new SqlParameter("paramFirstName", first_name)
				//};


				cmd.Parameters.AddWithValue("paramLastName", last_name);
				cmd.Parameters.AddWithValue("paramFirstName", first_name);
				cmd.ExecuteNonQuery();
			}
			finally
			{
				if(connection!=null)connection.Close();
			}
		}
		public void InsertBook(int author, string title, int pages, decimal price) {
			try
			{
				connection.Open();
				string command = $@"
				IF NOT EXISTS (SELECT title FROM Books WHERE title = '{title}') 
				BEGIN	
						INSERT INTO Books(author, title, pages, price)
						VALUES ('{author}', '{title}', '{pages}','{price}')
				END";
				cmd = new SqlCommand(command, connection);
				cmd.ExecuteNonQuery();
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
		public void SelectAuthors()
		{
			try 
			{
				connection.Open();
				string command = "SELECT * FROM Authors";
				cmd = new SqlCommand(command, connection);
				SqlDataReader reader = cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).PadRight(10)} {reader.GetName(1).PadRight(15)} {reader.GetName(2).PadRight(15)}");
				while (reader.Read())
				{
					Console.WriteLine($"{reader[0].ToString().PadRight(10)} {reader[1].ToString().PadRight(15)} {reader[2].ToString().PadRight(15)}");
                }
			}
			finally 
			{
				if (connection != null) connection.Close();
			}
		}
		public void SelectBooks(string AuthorName = "")
		{
			try
			{
				connection.Open();
				string command = $@"
				SELECT 
					title AS Title,
					[Author] = FORMATMESSAGE('%s %s', first_name, last_name)  
				FROM Books
				JOIN Authors ON author=author_id
				WHERE CONCAT(first_name, ' ', last_name) = '{AuthorName}'";
				cmd = new SqlCommand(command, connection);
				SqlDataReader reader = cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).ToString().PadRight(32)} {reader.GetName(1).ToString().PadRight(32)}");
				while (reader.Read()) {
					Console.WriteLine($"{reader[0].ToString().PadRight(32)} {reader[1].ToString().PadRight(32)}");
				}
			}
			finally 
			{
				if (connection != null) connection.Close();
			}
		}

	}
}
