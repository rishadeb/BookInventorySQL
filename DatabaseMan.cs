using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace DemoApplication
{
    public class DatabaseMan : IDatabaseMan
    {
        MySqlConnection cnn;
        MySqlCommand command;
        bool isConnected = false;
        public DatabaseMan()
        {

        }
        public bool ConnectDb(string server, string port)
        {
            try
            {
                cnn = new MySqlConnection("Server=" + server + ";Port =" + port + ";Database=demodb; user id=root;Pwd=mysql;Connect Timeout=3");
                cnn.Open();
                isConnected = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                isConnected = false;
            }
            return isConnected;
        }

        public void CloseDb()
        {
            cnn.Close();
        }

        public void Update(string name, string author, string edition, string date, string price, string id)
        {
            string sql;

            MySqlDataAdapter sda = new MySqlDataAdapter();
            //sql = string.Format("Update firsttable set Name='" + "{0}" + "'" + ",Author='" + "{1}" + "',Edition='" + "{2}" + "',DatePublished='" + "{3}" + "',Price='" + "{4}" + "' where ID={5}",name, author, edition, date, price, id);
            command = new MySqlCommand("Update firsttable set Name=@Name,Author=@Author,Edition=@Edition,DatePublished=@Date,Price=@Price where ID=@ID", cnn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Author", author);
            command.Parameters.AddWithValue("@Edition", edition);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@ID", id);
            sda.InsertCommand = command;
            sda.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void Delete(string id)
        {
            String sql;

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sql = string.Format("Delete From firsttable where ID={0}", id);
            command = new MySqlCommand(sql, cnn);
            sda.InsertCommand = command;
            sda.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public DataTable SelectAll()
        {
            String sql;
            // Select items from table
            sql = "Select ID,Name,Author,Edition,DatePublished,Price from firsttable Limit 50";
            command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            // Create datatable
            DataTable dt = new DataTable();
            sda.Fill(dt);
            command.Dispose();
            return dt;
        }

        public DataTable SelectDistinct()
        {
            String sql;

            // Select items from table
            sql = "Select Distinct Name,Author from firsttable";
            command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            // Create datatable
            DataTable dt = new DataTable();

            sda.Fill(dt);
            command.Dispose();
            return dt;
        }

        public string SelectCount(string name)
        {
            String sql, Output = "";
            sql = string.Format("SELECT COUNT(NAME) FROM firsttable WHERE NAME='" + "{0}" + "'", name);
            command = new MySqlCommand(sql, cnn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0);
            }
            dataReader.Close();
            return Output;
            
        }

        public DataTable SelectWhere(string name)
        {
            String sql;
            // Select items from table
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@Name";
            param.Value = name;
            sql = String.Format("Select * from firsttable WHERE NAME= @Name");
            command = new MySqlCommand(sql, cnn);
            command.Parameters.Add(param);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);

            // Create datatable
            DataTable dt = new DataTable();
            sda.Fill(dt);
            command.Dispose();
            return dt;
        }

        public void Insert(string name, string author, string edition, string date, string price)
        {
            String sql;

            MySqlDataAdapter sda = new MySqlDataAdapter();

            // Dont do this!!
            // sql = string.Format(
            // "Insert into firsttable(Name,Author,Edition, DatePublished) values('" + "{0}" + "'," + "'" + "{1}" + "'," + "'" + "{2}" + "'," + "'" + "{3}" + "'," + "'" + "{4}" + "')", name, author, edition, date, price);
           
            command = new MySqlCommand("Insert into firsttable(Name,Author,Edition, DatePublished,Price) values(@Name,@Author,@Edition,@Date,@Price)", cnn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Author", author);
            command.Parameters.AddWithValue("@Edition", edition);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@Price", price);
            sda.InsertCommand = command;
            sda.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }
    }
}
