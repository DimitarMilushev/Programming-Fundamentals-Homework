using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long photos = long.Parse(Console.ReadLine());
            long filterdelay = long.Parse(Console.ReadLine());
            long percent = long.Parse(Console.ReadLine());
            long downloaddelay = long.Parse(Console.ReadLine());


            decimal totalpictures = (photos * percent) / 100m;
            totalpictures = Math.Ceiling(totalpictures);
            long filtertime = photos * filterdelay;
            long downloadtime =(long) totalpictures * downloaddelay;

            TimeSpan time = TimeSpan.FromSeconds(downloadtime + filtertime);
            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", time);
        }
    }
}