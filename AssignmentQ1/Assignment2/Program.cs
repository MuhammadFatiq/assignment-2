using System;

public abstract class Telephone
{
    protected string Phonetype;

    public abstract void Ring();
}

public class ElectronicPhone : Telephone
{
    public ElectronicPhone()
    {
        Phonetype = "Digital";
    }

    public void Run()
    {
        Ring(); 
    }

    public override void Ring() 
    {
        Console.WriteLine($"Electronic phone is making a different sound.");
    }
}

public class DigitalPhone : Telephone
{
    public DigitalPhone()
    {
        Phonetype = "Digital";
    }

    public override void Ring()
    {
        Console.WriteLine($"Digital phone is ringing.");
    }
}

public class TalkingPhone : Telephone
{
    public TalkingPhone()
    {
        Phonetype = "Talking";
    }

    public override void Ring()
    {
        Console.WriteLine($"Talking phone is ringing.");
    }
}

public class Program
{
    public static void Main()
    {
       
        ElectronicPhone electronicPhone = new ElectronicPhone();
        electronicPhone.Run(); 

       
        DigitalPhone digitalPhone = new DigitalPhone();
        digitalPhone.Ring(); 

        
        TalkingPhone talkingPhone = new TalkingPhone();
        talkingPhone.Ring(); 
    }
}
