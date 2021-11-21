using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_oecercises {
    class LineSegment{
        public MyPoint Start { get; set; }
        public MyPoint End { get; set; }
        public LineSegment(float sX, float sY, float eX, float eY) {
            Start = new MyPoint(sX, sY);
            End = new MyPoint(eX, eY);
        }
        public LineSegment(MyPoint start, MyPoint end) {
            Start = start;
            End = end;
        }

        public float CalculateLength() {
            return (float)Math.Sqrt((Math.Pow((Start.X - End.X), 2)+Math.Pow((Start.Y-End.Y),2)));
        }

    }
}
