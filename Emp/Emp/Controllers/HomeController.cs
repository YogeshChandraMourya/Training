using Emp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;

namespace Emp.Controllers
{
    public class HomeController : Controller
    {
        System.Data.SqlClient.SqlConnection _con;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            
            

            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Employee(Employee employee)
        {
            _con = new SqlConnection(CommonVariables.conString);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CommonVariables.select, _con);
             SqlCommand cmd= new SqlCommand(CommonVariables.insert,_con);
            cmd.Parameters.AddWithValue("@Id", employee.Id);
            cmd.Parameters.AddWithValue("@Name", employee.Name);
            cmd.Parameters.AddWithValue("@Description", employee.Description);
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
                ViewBag.Result = "Record not Inserted"+ex.Message;
            }
            if(_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            return View(employee);
        }

        private void OpenConnection()
        {
            if (_con.State != ConnectionState.Broken | _con.State != ConnectionState.Closed)
            {
                _con.Open();
            }
        }

        

        public IActionResult Customer()
        {

            _con= new SqlConnection(CommonVariables.conString);
            
          
            //qlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from CustTbl", _con);
            //sqlDataAdapter.SelectCommand = new SqlCommand("Select * from EmpTbl");
            SqlCommand cmd= new SqlCommand(CommonVariables.insert2, _con);

            
            cmd.Parameters.AddWithValue("@CustId", "89");
            cmd.Parameters.AddWithValue("@CustType", "D");
            cmd.Parameters.AddWithValue("@Address", "GreenLand");
            cmd.Parameters.AddWithValue("@City", "Falthu");
            cmd.Parameters.AddWithValue("@Contact", "12345");
            try {
                OpenConnection();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    ViewBag.Result = "Record Inserted Successfully";
                } }
            catch (Exception ex) {
                ViewBag.Result = "Record not Inserted" + ex.Message;
            }
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }


            return View();
        }
        public IActionResult Billing()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Billing(Billing billing)
        {


            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from BillTbl", _con);
            //sqlDataAdapter.SelectCommand = new SqlCommand("Select * from EmpTbl");
            sqlDataAdapter.InsertCommand = new SqlCommand($"Insert into BillTbl values ({billing.BillingId},'{billing.BillingName}','{billing.BillingDescription}',{billing.BillingStatus},'{billing.BillingAddress}')", _con);

            int result = sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            sqlDataAdapter.Fill(dataSet);
            if (result == 1)
            {
                ViewBag.Result = "Record Inserted Successfully";
            }
            else
            {
                ViewBag.Result = "Record not Inserted";
            }

            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            return View("Billing", billing);
        }
        public IActionResult Visitor()
        {
            return View();
        }
        public IActionResult Sales()
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