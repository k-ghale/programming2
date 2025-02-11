//Parent Class - Abstract
abstract class Shape{
    public string name{get;}
    public abstract double Area {
        get;
    }

    public Shape(string name){
        this.name = name;
    }

    public override string ToString(){
        return $"{name}: {Area:F2}"; 
    }
}

//Left Hand Side
class Square : Shape
{
    public double Length { get; }
    public override double Area => Length*Length;

    public Square(string name, double length) : base(name)
    {
        Length = length;
    }

}

class Circle : Square
{
    public override double Area => Math.PI * Length * Length;

    public Circle(string name, double length) : base(name,length)
    {
    }
}

//Right Hand Side
class Rectangle : Shape
{
    public double Length {get;}
    public double Width {get;}
    public override double Area => Length*Width;

    public Rectangle(string name, double length, double width) : base(name)
    {
        Length = length;
        Width = width;
    }
}

class Ellipse : Rectangle 
{
    public override double Area => Math.PI * Width * Length;

    public Ellipse(string name, double length, double width) : base(name,length,width)
    {
    }
}


class Triangle : Rectangle 
{
    public override double Area => 0.5 * Width * Length;

    public Triangle(string name, double length, double width) : base(name,length,width)
    {
    }
}

class Diamond : Rectangle 
{
    public override double Area => Width * Length;

    public Diamond (string name, double length, double width) : base(name,length,width)
    {
    }
}

//Main 
class Program{
    public static void Main(string[] args){
        //although Shape is an abstract is can be used as a reference type
        //any child class of Shape is also a Shape
        double length = 2;
        double width = 3;
        List<Shape> shapes = new List<Shape>
        {
            new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Triangle($"triangle – bas:{length}, hei:{width}", length, width),
                //doubling width and length
                new Triangle($"triangle – bas:{length *= 2}, hei:{width *= 2}", length, width),
                new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Ellipse($"ellipse – min:{length}, maj:{width}", length, width),
                new Diamond($"diamond – min:{length}, maj:{width}", length, width)
        };
        foreach (Shape shape in shapes)
            Console.WriteLine(shape); 
    }
}


