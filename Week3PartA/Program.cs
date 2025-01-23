
class Week3PartA
{
   public static void Main(string[] args){
        List<int> l1 = new List<int>();

        l1.Add(4);
        l1.Add(2);
        l1.Add(3);
        l1.Add(1);

        foreach (int item in l1)
        {
           Console.WriteLine(item); 
        }

        Console.WriteLine();

        List<int> sorted = bubSort(l1);

        foreach (int i in sorted)
        {
           Console.WriteLine(i); 
        }

   }

   public  static List<int> bubSort(List<int> l1){
       for (int i = 0; i < l1.Count - 1; i++)
       {
           for (int j = 0; j < l1.Count - i - 1; j++)
           {
               if(l1[j] > l1[j+1]){
                   int temp = l1[j];
                   l1[j] = l1[j+1];
                   l1[j+1] = temp;
               } 
           }
       }
       return l1;
   }
}

