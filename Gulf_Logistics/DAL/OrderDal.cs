using Gulf_Logistics.Models;
using Newtonsoft.Json.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using ExcelDataReader;

namespace Gulf_Logistics.DAL
{
    public class OrderDal : IOrdersDAL
    {
        MySqlConnection _connection = null;
        MySqlCommand _command = null;


        private readonly IConfiguration _configuration;

        //public string GetConnectionString()
        //{ 
        //var builder = new ConfigurationBinder().SetBasePath(Directory.GetCurrentDirectory()).
        //}

        public OrderDal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Gulf_Logistics.Models.Orders> GetOrderList()
        {
            List<Orders> orderList = new List<Orders>();

            var con = _configuration.GetConnectionString("DefaultConnection");
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Orders", conn))
                {
                    cmd.CommandType = CommandType.Text;


                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            while (reader.Read())
                            {
                                orderList.Add(new Orders()
                                {
                                    //Id = reader.GetInt32("id"),
                                    //na
                                });
                            }
                        }
                    }
                }
            }
            return orderList;

        }

        public void UploadExcel()
        {
            var filepath = "";
            using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Use the reader as a DataSet to iterate through sheets, rows, and columns
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true // Set to true if the first row contains column names
                        }
                    });

                    foreach (DataTable table in result.Tables)
                    {
                        // Loop through each row
                        foreach (DataRow row in table.Rows)
                        {
                            // Loop through each column
                            foreach (var cell in row.ItemArray)
                            {
                                Console.Write($"{cell}\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
