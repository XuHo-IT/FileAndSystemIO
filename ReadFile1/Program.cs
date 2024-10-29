using System.Text;

namespace ReadFile
{
    public class Class1
    {

        static void Main(String[] args)
        {
            Console.WriteLine("**Demo FileStream Class**");
            using FileStream fileStream = File.Open("MyFile.dart", FileMode.Create);
            string msg = "abcdef";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            fileStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            fileStream.Position = 0;
            Console.WriteLine("Print message");
            byte[] byteFromFile = new byte[msgAsByteArray.Length];
            for (int i = 0; i < byteFromFile.Length; i++)
            {
                byteFromFile[i] = (byte)fileStream.ReadByte();
                Console.WriteLine($"{byteFromFile[i],5}");
            }
            Console.WriteLine("message");
            Console.WriteLine(Encoding.Default.GetString(byteFromFile));
            Console.ReadLine();
        }
    }
}
