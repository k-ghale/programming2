/*
class Rectangle{
    public int length;
   public int width;

    public static Rectangle operator+(Rectangle a, Rectangle b){
        Rectangle r = new Rectangle();{
            r.length = a.length + b.length;
            r.width = a.width + b.width;
        }
        return r;
    }

    public static Rectangle operator==(Rectangle a, Rectangle b){
        var c = new Rectangle();
        return c;
    }

    public static Rectangle operator!=(Rectangle a, Rectangle b){
        return b; 
    }
}

class Program{
    static void Main(string[] args){
        Rectangle r1 = new Rectangle(){length = 10, width = 20}; 
        Rectangle r2 = new Rectangle(){length = 20, width = 10}; 
        var r3 = r1 + r2;

        Console.WriteLine(r3.length);
        Console.WriteLine(r3.width);

    }
}
*/

public class Complex{
    public int Real{get;}
    public int Imaginary{get;}
    public double Argument => Math.Atan2(Imaginary,Real);
    public double Modulus => Math.Sqrt((Imaginary*Imaginary) + (Real*Real));
    public static Complex Zero => new Complex(0,0);

    public Complex(int real = 0, int imaginary = 0 ){
        Real = real;
        Imaginary = imaginary;
    }
    
    public override string ToString(){
        return $"{Real} {Imaginary}"; 
    }

    public static Complex operator +(Complex lhs, Complex rhs){
        int real = lhs.Real + rhs.Real;
        int imaginary = lhs.Imaginary + rhs.Imaginary;
        return new Complex(real, imaginary);
    }

    public static Complex operator -(Complex lhs, Complex rhs){
        int real = lhs.Real - rhs.Real;
        int imaginary = lhs.Imaginary - rhs.Imaginary;
        return new Complex(real, imaginary);
    }

    public static bool operator ==(Complex lhs, Complex rhs){
        return lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary;
    }

    public static bool operator !=(Complex lhs, Complex rhs){
        return false;
    }
    
    //Additional Tasks
    public static Complex operator *(Complex lhs, Complex rhs){
        int real = (lhs.Real*rhs.Real)-(lhs.Imaginary*rhs.Imaginary);
        int imaginary =  (lhs.Real*rhs.Imaginary)+(lhs.Imaginary + rhs.Real);
        return new Complex(real, imaginary);
    }

    public static Complex operator -(Complex c){
        return new Complex(-c.Real, -c.Imaginary);
    }
}

class Program{
    public static void Main(string[] args){
        Complex c0 = new Complex(-2, 3);
        Complex c1 = new Complex(-2, 3);
        Complex c2 = new Complex(1, -2);
        Console.WriteLine($"{c0}");
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
        Console.WriteLine($"{c1} - {c2} = {c1 - c2}");
        Complex c3 = c1 + c2;
        Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");
        Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
        Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");

        
        //Additional Tasks
        Console.WriteLine("Additional Tasks");
        
        Complex c4 = c1 * c2;
        Console.WriteLine($"{c4}");
        
        Complex c5 = -c4;
        Console.WriteLine($"{c5}");
    }
}





