namespace OOP_SAMPLE
{
    public class QuadraticEquation
    {
        private int a;
        public int b;
        public int c;

        public QuadraticEquation(int a, int b, int c)
        {
            this.A = a;
            this.b = b;
            this.c = c;

        }

        public int A
        {
            get { return this.a; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Value of a must be != 0");
                }

                else
                {
                    this.a = value;
                }
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Equation: {a}x2 + {b}x + {c} = 0");
        }

        public int GetRootsCount()
        {
            int discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                return 2;
            }

            else if (discriminant == 0)
            {
                return 1;
            }

            return 0;

        }

        public double[] GetRoots()
        {
            int discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                return new[] { x1, x2 };
            }

            else if (discriminant == 0)
            {
                double x1 = (double)-b / (2 * a);
                return new[] { x1 };
            }



            return Array.Empty<double>();
        }
    }
}