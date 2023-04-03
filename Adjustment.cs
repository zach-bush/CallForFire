using System;

//This will get the rounds on target

public class Adjustment
{
    Radio _radio = new Radio();
    private string _adjustment = "";

    private string _verify = "";

    public void AdjustmentPhase()
    {
        Console.WriteLine();
        Console.WriteLine("What are your adjustments based on your spotting? ");
        _adjustment = Console.ReadLine();
    }

    public void VerifyAdjustment()
    {
        Console.WriteLine();
        _radio.Transmit("Steel Rain01","Mamba47 are your adjustments on target? ");
        _verify = Console.ReadLine();

        if (_verify != "yes")
        {
            AdjustmentPhase();
        }

    }
    public void SendAdjustments()
    {
        Console.WriteLine();
        _radio.Transmit("Mamba47", $"{_adjustment}");
    }

    
    
}