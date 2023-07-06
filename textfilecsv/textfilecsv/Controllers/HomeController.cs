using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using textfilecsv.Models;
using System.IO;
using System.Text;

namespace textfilecsv.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        string details = "";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //string file = @"C;\Temp\Mourya.txt";
            //string seperator = "";
            //StringBuilder sb = new StringBuilder();
            //string[] headings = { "RollNo", "Name", "Mark1", "Mark2", "Total" };
            //sb.AppendLine(string.Join(seperator, headings));
            //foreach (char stu in details)
            //{
            //    string[] newLine = { details };
            //    sb.AppendLine(string.Join(seperator + newLine, newLine));
            //}

            List<student> StudentDetails = new List<student>();
            string nameoffile = @"C:\Temp\Mourya.txt";
            FileInfo fi = new FileInfo(nameoffile);
            using (StreamReader reader = fi.OpenText())
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    student student = new student();
                    var rawdata = s.Split(",");
                    student.rollno = int.Parse(rawdata[0]);
                    student.name = rawdata[1];
                    student.mark1 = int.Parse(rawdata[2]);
                    student.mark2 = int.Parse(rawdata[3]);
                    student.total = student.mark1 + student.mark2;
                    StudentDetails.Add(student);
                }
            }

            return View("StudentDetails", StudentDetails);
        }



        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult student()
        {
            return View();
        }
        [HttpPost]
        public IActionResult student(student stu)
        {
            string nameofFile = @"C:\Temp\Mourya.txt";
            FileInfo fi = new FileInfo(nameofFile);
            details += stu.rollno + ",";
            details += stu.name + ",";
            details += stu.mark1 + ",";
            details += stu.mark2 + ",";
            stu.total = stu.mark1 + stu.mark2;
            details += stu.total;
            using (StreamWriter sw = fi.AppendText())
            {
                sw.WriteLine(details);
            }
            #region
            //StreamReader streamReader = new StreamReader(nameofFile);
            //streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            //string strData = streamReader.ReadLine();
            //while (strData != null)
            //{
            //    //Print the String data
            //    Console.WriteLine(strData);
            //    //Then Read the next String data
            //    strData = streamReader.ReadLine();
            //}
            //Console.ReadLine();
            ////Close the streamReader Object
            //streamReader.Close();
            //Console.ReadKey();
            #endregion




            return View("student", stu);



        }

        public IActionResult EditText(int id)
        {
            student stu = getStudent(id);
            return View(stu);
            //return View();
        }

        private student getStudent(int id)
        {
            string fileName = @"C:\temp\Mourya.txt";
            FileInfo fileInfo = new FileInfo(fileName);
            student data = new student();
            using (StreamReader r = fileInfo.OpenText())
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    string[] values = line.Split(",");
                    if (int.Parse(values[0]) == id)
                    {
                        data.rollno = int.Parse(values[0]);
                        data.name = values[1];
                        data.mark1 = int.Parse(values[2]);
                        data.mark2 = int.Parse(values[3]);
                        data.total = int.Parse(values[4]);
                        break;
                    }
                }
            }
            return data;
        }

        [HttpPost]
        public IActionResult EditText(student stu)
        {
            List<student> students = new List<student>();
            string filename = @"C:\temp\Mourya.txt";
            FileInfo file = new FileInfo(filename);
            using (StreamReader reader = file.OpenText())
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    student student = new student();
                    var rawdata = s.Split(",");
                    student.rollno = int.Parse(rawdata[0]);
                    student.name = rawdata[1];
                    student.mark1 = int.Parse(rawdata[2]);
                    student.mark2 = int.Parse(rawdata[3]);
                    student.total = student.mark1 + student.mark2;
                    students.Add(student);
                }
            }
            for (int i = 0; i < students.Count; i++)
            {

                if (students[i].rollno == stu.rollno)
                {
                    //TryUpdateModelAsync(s[i]);
                    students[i].rollno = stu.rollno;
                    students[i].name = stu.name;
                    students[i].mark1 = stu.mark1;
                    students[i].mark2 = stu.mark2;
                    students[i].total = stu.mark1 + stu.mark2;
                    break;

                }
            }
            using (FileStream fs = new FileStream(filename, FileMode.Truncate)) { }
            using (StreamWriter sw = file.AppendText())
            {
                for (int i = 0; i < students.Count; i++)
                {
                    string details = "";
                    details += students[i].rollno + ",";
                    details += students[i].name + ",";
                    details += students[i].mark1 + ",";
                    details += students[i].mark2 + ",";
                    stu.total = students[i].mark1 + students[i].mark2;
                    details += students[i].total;
                    sw.WriteLine(details);
                }
            }
            return View();


        }
       
        public IActionResult DeleteText(int id)
        {
            student student = getStudent(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(IFormCollection form)
        {
            String path = @"C:\temp\Mourya.txt";
            List<String> lines = new List<String>();



            using (StreamReader reader = new StreamReader(path))
            {
                String line;



                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        String[] split = line.Split(',');



                        if (int.Parse(split[0]) != int.Parse(form["id"]))
                        {
                            line = String.Join(",", split);
                            lines.Add(line);
                        }
                    }



                }
            }



            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }



            return RedirectToAction("StudentDetails");

        }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}