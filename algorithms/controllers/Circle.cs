using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public  class Circle
    {
    private double Pi = 3.14;
    private double radius;
    public void SetRadius(double radius)
    {
        if (radius > 0)
        {
            this.radius = radius;
        }
        else
        {
            Console.WriteLine("Radius must be a positive number.");
        }

    }
    public double GetRadius()
    {
        return radius;
    }

    public double GetArea()
    {
        return Pi * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Pi * radius;
    }

}

