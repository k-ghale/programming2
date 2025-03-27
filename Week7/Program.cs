
public class Fraction{

    public int Top {get ;}
    public int Bottom {get ;} 

    public Fraction(int top = 0, int bottom = 1){
        if( bottom ==  0 ){
            throw new ArgumentException("Denominator cannot be zero");
        }
        Top = top;
        Bottom = bottom;
    }

    public static Fraction operator +(Fraction left, Fraction right){
        int new_top = (left.Top * right.Bottom) + (right.Top * left.Bottom); 
        int new_bottom = left.Bottom * right.Bottom; 
        return new Fraction(new_top, new_bottom); 
    }

    public static Fraction operator -(Fraction left, Fraction right){
        int new_top = (left.Top * right.Bottom) - (right.Top * left.Bottom); 
        int new_bottom = left.Bottom * right.Bottom;

        if ( new_top < 0 ){
            throw new ArgumentException(" Subtraction resulted in negative fraction, which is not allowed. ");
        }
        return new Fraction(new_top, new_bottom);
    }

    public override string ToString(){
        return $"{Top} / {Bottom}"; 
    }
}


class Program{ 
   public static void Main(string[] args){
      {
        try
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);

            
            Console.WriteLine($"Fraction 1: {f1}");  
            Console.WriteLine($"Fraction 2: {f2}"); 

            Fraction sum = f1 + f2;
            Console.WriteLine($"Sum: {sum}");  // Expected output: "Sum: 5/6"

            Fraction difference = f1 - f2;
            Console.WriteLine($"Difference: {difference}");  // Expected output: "Difference: 1/6"

            Fraction invalid = new Fraction(1, 2) - new Fraction(3, 2);  
            // This should throw an exception since 1/2 - 3/2 is negative

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
      }
   }
}
