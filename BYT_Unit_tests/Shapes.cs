
public interface IShape
{
    double CalculateArea();
    double CalculateVolume();
}
    
public class Sphere : IShape
{
    private readonly double radius;

    public Sphere(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero.");
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }

    public double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}
    
public class Cylinder : IShape
{
    private readonly double radius;
    private readonly double height;

    public Cylinder(double radius, double height)
    {
        if (radius <= 0 || height <= 0)
            throw new ArgumentException("Radius or height must be greater than zero.");
        this.radius = radius;
        this.height = height;
    }

    public double CalculateArea()
    {
        return 2 * Math.PI * radius * (radius + height);
    }

    public double CalculateVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }

}


public class Cube: IShape
{
    private readonly double side;

    public Cube(double side)
    {
        if(side <= 0)
            throw new ArgumentException("Side must be greater than zero.");
        this.side = side;
    }

    public double CalculateArea()
    {
        return 6 * Math.Pow(side, 2);
    }

    public double CalculateVolume()
    {
        return Math.Pow(side, 3);
    }

}

public class Rectangle : IShape
{
    private readonly double length;
    private readonly double width;

    public Rectangle(double length, double width)
    {
        if (length <= 0 || width <= 0)
            throw new ArgumentException("Length or Width must be greater than zero.");
        this.length = length;
        this.width = width;
    }


    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculateVolume()
    {
        // For 2D shapes, volume is not applicable.
        // Height of 2D shape is 0, therefore volume is 0
        return 0;
    } 
}



