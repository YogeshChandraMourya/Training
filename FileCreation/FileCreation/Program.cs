using System.IO;
using System.Text;


//File.Create("Mourya.txt");
//if (File.Exists("Mourya.txt"))
//{
//    Console.WriteLine("File Exists");
//}
//else
//{
//    Console.WriteLine("File not found");
//}

// Write file using StreamWriter
using (StreamWriter writer = new StreamWriter(Path.GetFullPath("Mourya.txt")))
{
    writer.WriteLine("Steve Rogers");
    writer.WriteLine("Tony Stark");
    writer.WriteLine("Natasha Romanolf ");
    writer.WriteLine("Bruce Banner");
    writer.WriteLine("Hawkeye");
}
// Read a file
string readText = File.ReadAllText(Path.GetFullPath("Mourya.txt"));
Console.WriteLine(readText);

string fileName = @"Mourya.txt";
FileInfo fi = new FileInfo(fileName);
string destinationFile = @"StephenHawking.txt";
//fi.Encrypt();
//fi.Decrypt();

try
{// Check if file already exists. If yes, delete it.
    if (fi.Exists) 
    { fi.Delete(); }
    // Create a new file
    using (FileStream fs = fi.Create())
    {
        Byte[] txt = new UTF8Encoding(true).GetBytes("New file."); fs.Write(txt, 0, txt.Length); Byte[] author = new UTF8Encoding(true).GetBytes("Writer God"); fs.Write(author, 0, author.Length);
    }
    if (!fi.Exists)
    {//Create the file.
        using (FileStream fs = fi.Create())
        {
            Byte[] info = new UTF8Encoding(true).GetBytes("File Start");
            fs.Write(info, 0, info.Length);
        }
    }
    // Write file contents on console.
    using (StreamWriter sw = fi.CreateText())
    {
        sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
        sw.WriteLine("Avengers:Endgame");
        sw.WriteLine("Marvel");
        sw.WriteLine("Author: StanLee");
        sw.WriteLine("Done! ");
    }
    using (StreamReader sr = File.OpenText(fileName))
    {
        string s = ""; while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
    using (FileStream fs = fi.Open(FileMode.Open, FileAccess.Write))
    {
        Byte[] info = new UTF8Encoding(true).GetBytes("Add more text");
        fs.Write(info, 0, info.Length);
    }
    using (FileStream fs = fi.OpenRead())
    {
        byte[] byteArray = new byte[1024];
        UTF8Encoding fileContent = new UTF8Encoding(true);
        while (fs.Read(byteArray, 0, byteArray.Length) > 0)
        {
            Console.WriteLine(fileContent.GetString(byteArray));
        }
    }
    using (StreamReader reader = fi.OpenText())
    {
        string s = "";
        while ((s = reader.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
    using (FileStream fs = fi.OpenWrite())
    {
        Byte[] info = new UTF8Encoding(true).GetBytes("New File using OpenWrite Method\n");
        fs.Write(info, 0, info.Length);
        info = new UTF8Encoding(true).GetBytes("----------START------------------------\n");
        fs.Write(info, 0, info.Length);
        info = new UTF8Encoding(true).GetBytes("Author:Jk Rowling\n");
        fs.Write(info, 0, info.Length);
        info = new UTF8Encoding(true).GetBytes("Book:Harry Potter Series\n");
        fs.Write(info, 0, info.Length);
        info = new UTF8Encoding(true).GetBytes("----------END------------------------");
        fs.Write(info, 0, info.Length);
    }
    using (FileStream fs = File.OpenRead(fileName))
    {
        byte[] byteArray = new byte[1024];
        UTF8Encoding fileContent = new UTF8Encoding(true);
        while (fs.Read(byteArray, 0, byteArray.Length) > 0)
        {
            Console.WriteLine(fileContent.GetString(byteArray));
        }
    }
    using (StreamWriter sw = fi.AppendText())
    {
        sw.WriteLine("--------- Append Text Start ----------");
        sw.WriteLine("James Bond Mission");
        sw.WriteLine("Movie: Die Another Day");
        sw.WriteLine("Agent Code 007");
        sw.WriteLine("--------- Append Text End ----------");
    }
    // Read all text
    string readText1 = File.ReadAllText(fileName);
    Console.WriteLine(readText1);
    fi.CopyTo(destinationFile, true);
    fi.MoveTo(destinationFile);
    fi.Delete();


}
catch (Exception Ex)
{
    Console.WriteLine(Ex.ToString());
    Console.WriteLine(Ex.Message);

}

