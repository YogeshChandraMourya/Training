using ADO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Data;
using System.Data.Sql;
using Microsoft.Data.SqlClient;

namespace ADO.Controllers
{
    public class HomeController : Controller
    {
        private const string cons = "Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=Shopdb;User ID=sa;Password=Welcome2evoke@1234";
        SqlConnection _con = new SqlConnection(cons);



        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        {
            return HomePage();
        }

        private IActionResult HomePage()
        {
            SqlConnection con = new SqlConnection(cons);

            if (con.State == System.Data.ConnectionState.Broken

            || con.State == System.Data.ConnectionState.Closed)

            {

                con.Open();

            }



            SqlDataAdapter adap = new SqlDataAdapter("SELECT * from brands", con);

            DataSet ds = new DataSet();

            adap.Fill(ds);



            //ds.WriteXml("dsData.xml");



            DataTable dt = ds.Tables[0];

            List<Brand> brands = new List<Brand>();



            foreach (DataRow row in ds.Tables[0].Rows)

            {

                Brand brand = new Brand()

                {

                    BrandId = int.Parse(row["brand_Id"].ToString()),

                    BrandName = row["brand_name"].ToString(),





                };



                brands.Add(brand);





            }



            con.Close();

            return View(brands);

        }

        public IActionResult BrandInsert()
        {
            return View();
        }
        [HttpPost]

        public IActionResult BrandInsert(Brand brand)
        {
            return Insert(brand);
        }

        private IActionResult Insert(Brand brand)
        {
            _con = new SqlConnection(cons);
            SqlCommand cmd = new SqlCommand(CommonVariables.insertbr, _con);
            cmd.Parameters.AddWithValue("@BrandId", brand.BrandId);
            cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
            try
            {
                OpenConnection();
                int result = cmd.ExecuteNonQuery();
                //sqlDataAdapter.Fill(dataSet);
                if (result == 1)
                {
                    ViewBag.Result = "Record Inserted Successfully";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Result = "Record not Inserted" + ex.Message;
            }
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            return View(brand);
        }

        public IActionResult BrandDelete()
        {
            return View();
        }
        [HttpPost]

        public IActionResult BrandDelete(Brand brand)
        {
            _con = new SqlConnection(cons);
            SqlCommand cmd = new SqlCommand(CommonVariables.deletebr, _con);
            cmd.Parameters.AddWithValue("@BrandId", brand.BrandId);
            
            try
            {
                OpenConnection();
                int result = cmd.ExecuteNonQuery();
                //sqlDataAdapter.Fill(dataSet);
                if (result == 1)
                {
                    ViewBag.Result = "Record Deleted Successfully";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Result = "Record not Deleted" + ex.Message;
            }
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            return View(brand);
        }
        public IActionResult BrandUpdate()
        {
            return View();
        }
        [HttpPost]

        public IActionResult BrandUpdate(Brand brand)
        {
            _con = new SqlConnection(cons);
            SqlCommand cmd = new SqlCommand(CommonVariables.updatebr, _con);
            cmd.Parameters.AddWithValue("@ChangeId", brand.BrandId);
            cmd.Parameters.AddWithValue("@BrandId", brand.BrandId);
            cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
            try
            {
                OpenConnection();
                int result = cmd.ExecuteNonQuery();
                //sqlDataAdapter.Fill(dataSet);
                if (result == 1)
                {
                    ViewBag.Result = "Record Updated Successfully";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Result = "Record not Updated" + ex.Message;
            }
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            return View(brand);
        }
        private void OpenConnection()
        {
            if (_con.State != ConnectionState.Broken | _con.State != ConnectionState.Closed)
            {
                _con.Open();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}