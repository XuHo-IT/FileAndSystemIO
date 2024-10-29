using System.Text;

namespace ReadFile
{
    public class Class1
    {
        
        static void Main(String[] args)
        {
            Console.WriteLine("**Demo FileStream Class**");
            using FileStream fileStream = File.Open("MyFile.dart", FileMode.Create);
            string msg = "ABCDEFG";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            fileStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            fileStream.Position = 0;
            Console.ReadLine();
        }
    }
}
