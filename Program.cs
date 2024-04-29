namespace d11_simpel_avlusning
{
    internal class Program
    {
        class Vector
        {
            double x, y, z;
            public Vector(double x, double y, double z)
            {
                this.x = x; this.y = y; this.z = z;
            }
            public override string ToString()
            {
                return $"({x} {y} {z})";
            }
            public static Vector operator +(Vector u, Vector v)
            {
                return new Vector(u.x + v.x, u.y + v.y, u.z + v.z);
            }
        }
        static void Main(string[] args)
        {
            int?[] ints = { 1, 2, 3, null };
            foreach (int? i in ints)
            {
                Console.WriteLine(i * 3);
            }

            Vector?[] vectors = { new Vector(1, 2, 1), new Vector(2, 3, -1), null };
            foreach(Vector? v in vectors)
            {
                Vector vio = new Vector(-1, 1, 2);
                Console.WriteLine(v + vio);
            }
        }
    }
}
