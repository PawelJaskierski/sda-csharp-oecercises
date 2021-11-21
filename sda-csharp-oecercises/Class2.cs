using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_oecercises {
    class LineSegment{
        public MyPoint Start { get; set; }
        public MyPoint End { get; set; }
        public LineSegment(float[] start, float[] end)
        {
                Start = new MyPoint(start);
                End = new MyPoint(end);
        }
        public LineSegment(MyPoint start, MyPoint end) {
            Start = start;
            End = end;
        }

        public float CalculateLength() {
            float answer = 0;
            for(int i = 0; i<Start.Coordinates.Length; i++){
                answer += (float)Math.Pow((Start.Coordinates[i] - End.Coordinates[i]),2);
            }
            return (float)Math.Sqrt(answer);
                
        }

    }
}
