using System;

//This will get the rounds on target

public class Adjustment
{
    Radio _radio = new Radio();
    private string _adjustment = "";
    private string _check = "";
    public void AdjustmentPhase()
    {
        Console.WriteLine();
        Console.WriteLine("What are your adjustments based on your spotting? ");
        _adjustment = Console.ReadLine();
    }

    public void SendAdjustments()
    {
        Console.WriteLine();
        _radio.Transmit("Mamba47", $"{_adjustment}");
    }

    
}