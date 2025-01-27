
class Week2Part2{
  public static void Main(string[] args){
      //obj1
      Pet pet1 = new Pet("Alex",2,"Dog");

      //obj2
      Pet pet2 = new Pet("Bonny",10,"Cat");
      pet2.SetOwner("Ghale");
      pet2.Train();

      //obj3
      Pet pet3 = new Pet("Max",7,"Bird");

      //obj4
      Pet pet4 = new Pet("Chester",5,"Goat");
      pet4.SetOwner("Leo");
      pet4.Train();

      //Creating a list to store the above objects
      List<Pet> p1 = new List<Pet>{pet1, pet2, pet3, pet4};
      
      //Using Methods 
      p1[0].Train();
      p1[0].SetOwner("Kabin");
        
      
      //Loop to display the list
      for(int i = 0; i <= p1.Count - 1 ; i++){
        Console.WriteLine(p1[i]);
      }

      //Prompt the user of his name and display only his pet
      Console.WriteLine("\nPlease Enter Your Name : ");
      string name = Console.ReadLine();

      Console.WriteLine("\nPets with the given owner name : ");
      for(int i = 0 ; i <= p1.Count - 1 ; i++){
        if(p1[i].Owner == name){
          Console.WriteLine(p1[i]);
        }
      }
  }
}

class Pet{
  public string Name{get;} 
  public string Owner{get; private set;}
  public int Age{get;}
  public string Description{get;}
  public bool IsHouseTrained{get; private set;}

  public Pet(string name, int age, string description){
    Name = name;
    Age = age;
    Description = description;
    Owner = "no one";
    IsHouseTrained = false;
  }

  public override string ToString()
    {
       return $"\nName : {Name} \nAge : {Age} \nDescription : {Description} \nOwner : {Owner} \nIsHouseTrained : {IsHouseTrained}";
    }

  public void SetOwner(string owner){
    Owner = owner;
  }

  public void Train(){
     IsHouseTrained = true;
  }

}


