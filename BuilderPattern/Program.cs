using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var picture = new PictureMetaBuilder()
                .WithAuthor("Daniel Korompai")
                .WithCoordinate("45.856896, 85.694723")
                .WithExposure(1/1200)
                .WithISO(800)
                .WithTime(DateTime.Now)
                .WithPath(new DirectoryInfo(@"C:\"))
                .BuildPicture();

            Console.WriteLine(picture.WriteAllData());
            Console.ReadKey();
        }
    }
}
