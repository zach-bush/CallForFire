using System;

//This will send an end of mission statement and end the program.

public class EOM
{
    Radio _radio = new Radio();
    private string eom = "";
    public void EndOfMissionStatement()
    {
        Console.WriteLine();
        Console.WriteLine("End the mission: ");
        eom = Console.ReadLine();

    }

    public void SendEOM()
    {
        Console.WriteLine();
        _radio.Transmit("Mamba47", $"{eom}");
    }

}
