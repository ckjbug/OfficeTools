using Spire.Pdf;
using System;

namespace DN5
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"C:\Users\Administrator\Desktop\input1.pdf");//pdf物理路径
            Console.WriteLine("转换中请耐心等待.....");
            doc.SaveToFile(@"C:\Users\Administrator\Desktop\output1.doc", FileFormat.DOC);//生成word的物理路径
            Console.WriteLine("转换成功");
        }
    }
}
