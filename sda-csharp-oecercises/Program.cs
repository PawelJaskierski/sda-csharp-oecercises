using System;

namespace sda_csharp_oecercises{
    class Program{
        static void Main(string[] args){
            LineSegment l1 = new LineSegment(new float[] {0,0,0}, new float[] {3,4,0});
            Console.WriteLine(l1.CalculateLength());
        }
    }
}
