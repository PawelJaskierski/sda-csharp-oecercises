using System;

namespace sda_csharp_oecercises{
    class Program{
        static void Main(string[] args){
            LineSegment l1 = new LineSegment(0, 0, 3, 4);
            Console.WriteLine(l1.CalculateLength());
        }
    }
}
