using System;
// the spotting class will  determine where the round landed in relation to the target

public class Spotting
{
    private Radio _radio = new Radio();
    private string _spotting = "";
    public void CallSpotting()
    {
        Console.WriteLine();
        Console.WriteLine("Steel Rain01: Mamba47, What is your spotting? ");
        _spotting = Console.ReadLine();
    }

    public void SendSpotting()
    {
        _radio.Transmit("Mamba47", $"{_spotting}");
    }

}