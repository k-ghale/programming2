
class Week3PartA
{
    public static void Main(string[] args){
        //create a list to store the objects
        List<Time> times = new List<Time>()
        {
            new Time(9, 35),
                new Time(18, 5),
                new Time(20, 500),
                new Time(10),
                new Time()
        };
        //display all the objects
        TimeFormat format = TimeFormat.Hour12;
        Console.WriteLine($"\n\nTime format is {format}");
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }
        //change the format of the output
        format = TimeFormat.Mil;
        Console.WriteLine($"\n\nSetting time format to {format}");
        //SetFormat(TimeFormat) is a class member, so you need the type to access it
        Time.SetFormat(format);
        //again display all the objects
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }
        //change the format of the output
        format = TimeFormat.Hour24;
        Console.WriteLine($"\n\nSetting time format to {format}");
        //SetFormat(TimeFormat) is a class member, so you need the type to access it
        Time.SetFormat(format);
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }

    }
}

class Time{
    private static TimeFormat TIME_FORMAT {get; set;} = TimeFormat.Hour12;
    public int Hour {get;}
    public int Minute {get;}

    public Time(int hours = 0 , int minutes = 0){
        Hour = hours;
        Minute = minutes;  
    }

    public override String ToString(){
        string result ;
        switch (TIME_FORMAT)
        {
            case TimeFormat.Mil:

                result = $"{Hour:D2}{Minute%100:D2}";
                break;

            case TimeFormat.Hour12:
                int hour12 = (Hour % 12 == 0) ? 12 : Hour % 12;
                string period = Hour >= 12 ? "PM" : "AM";
                result = $"{hour12:D2}:{Minute%100:D2} {period}";
                break;

            case TimeFormat.Hour24:
                result = $"{Hour:D2}:{Minute%100:D2}";
                break;

            default:
                result = "Invalid Format";
                break;

        }
        return result;
    }

    public static void SetFormat(TimeFormat timeFormat){
        TIME_FORMAT = timeFormat; 
    }



}
