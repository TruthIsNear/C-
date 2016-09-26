using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class vector
{
    public int x, y, z;
    public vector(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public void printvector()
    {
        Console.WriteLine("x={0} y={1} z={2}", x,y,z);
    }
}

class program
{
    static void Main()
    {
        vector vector1 = new global::vector(1, 2, 3);
        vector1.printvector();
    }
}