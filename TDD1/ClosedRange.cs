using System;

namespace TDD1
{
    public class ClosedRange
    {
        private int v1;
        private int v2;

        public ClosedRange(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            if (v1 > v2)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int getLowerEndpoint()
        {
            return v1;
        }

        public int getUpperEndpoint()
        {
            return v2;
        }

        public string toString()
        {
            return "[" + v1.ToString() + "," + v2.ToString() + "]";
        }

        public bool contains(int v)
        {
            return (v1 <= v && v2 >= v);
        }

        public bool equals(ClosedRange closedRange)
        {
            return (this.toString() == closedRange.toString());
        }

        public bool contains(ClosedRange closedRange)
        {
            return (v1 <= closedRange.v1 && v2 >= closedRange.v2);
        }
    }
}