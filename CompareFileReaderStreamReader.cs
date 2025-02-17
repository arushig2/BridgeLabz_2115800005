using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadingEfficiency
{
    public static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment25\\largefile.txt";

        Stopwatch swReader = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null) { }
        }
        swReader.Stop();
        Console.WriteLine($"StreamReader Time: {swReader.Elapsed.TotalSeconds} sec");

        Stopwatch swFileStream = Stopwatch.StartNew();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        swFileStream.Stop();
        Console.WriteLine($"FileStream Time: {swFileStream.Elapsed.TotalSeconds} sec");
    }
}
