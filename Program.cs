using System;

class Program {
    static void Main() {
        {
        Developer dev = new PanelDeveloper("KirpichStroy LLC");
        House house2 = dev.Create();

        dev = new WoodDeveloper("Private developer");
        House house = dev.Create();

        Console.WriteLine();
        }
    }
}
// abstract construction company class
abstract class Developer {
    public string Name {get; set;}
    public Developer (string n) {
    Name = n;

    }
    
    // factory method
    abstract public House Create();
}
class PanelDeveloper : Developer {
    public PanelDeveloper(string n) : base(n) {}
    public override House Create() {
        return new PanelHouse();
    }
}
// builds wooden houses
class WoodDeveloper : Developer {
    public WoodDeveloper(string n) : base(n){}

    public override House Create() {
        return new WoodHouse();
    }
}
abstract class House {}

class PanelHouse : House {
    public PanelHouse() {
        Console.WriteLine("The panel building has been built.");
    }
}
class WoodHouse : House {
    public WoodHouse() {
        Console.WriteLine("The wooden house has been built.");
    }
}


