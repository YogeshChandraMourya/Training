using ADO.netProject.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace ADO.netProject.Controllers
{
    public class HomeController : Controller

    {
        System.Data.SqlClient.SqlConnection _connection = new SqlConnection();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //staff();
            _logger = logger;
        }

        //private void staff()
        //{
        //    _connection = new System.Data.SqlClient.SqlConnection("Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=Shopdb;User ID=sa;Password=Welcome2evoke@1234");
        //    _connection.Open();
        //    SqlCommand cmd = new SqlCommand("Sp_Insert_staff", _connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@staff_id", 14);
        //    cmd.Parameters.AddWithValue("@first_name", "khjfdxf");
        //    cmd.Parameters.AddWithValue("@last_name", "jfbsah");
        //    cmd.Parameters.AddWithValue("@email", "jfbsah");
        //    cmd.Parameters.AddWithValue("@phone", 2134);
        //    cmd.Parameters.AddWithValue("@active", "jfbsah");
        //    cmd.Parameters.AddWithValue("@store_id", 1);
        //    cmd.Parameters.AddWithValue("@manager_id", 7);
        //    cmd.ExecuteNonQuery();
        //}


        public IActionResult Index()
        {
            return CustomerType();

        }
        public IActionResult Brand()
        {
            SqlConnection con = new SqlConnection(comvar.constr);
            if (con.State == System.Data.ConnectionState.Broken
            || con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataAdapter adap = new SqlDataAdapter("SELECT * from brands", con);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            //ds.WriteXml("dsdata.xml");
            DataTable dt = ds.Tables[0];
            List<Brand> Brands = new List<Brand>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Brand brand = new Brand()
                {
                    BrandId = int.Parse(row["brand_id"].ToString()),
                    BrandName = row["brand_name"].ToString(),
                   
                };

                Brands.Add(brand);

            }

            con.Close();
            return View(Brands);
            
        }

        private IActionResult CustomerType()
        {
            SqlConnection con = new SqlConnection(comvar.constr);
            if (con.State == System.Data.ConnectionState.Broken
            || con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataAdapter adap = new SqlDataAdapter("SELECT * from customers", con);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            //ds.WriteXml("dsdata.xml");
            DataTable dt = ds.Tables[0];
            List<CustomerType> Customers = new List<CustomerType>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                CustomerType customer = new CustomerType()
                {
                    customer_id = int.Parse(row["customer_id"].ToString()),
                    first_name = row["first_name"].ToString(),
                    last_name = row[2].ToString()
                };

                Customers.Add(customer);

            }

            con.Close();
            return View(Customers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}