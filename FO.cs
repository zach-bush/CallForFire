using System;

// Finds the enemy and send a call for fire mission to the FDC through the radio in order to destroy the enemy.
public class FO
{
    private Radio _radio = new Radio();
    private string _grid = "";
    private string _mils = "";
    private string _alt = "";
    private string _desc = "";
    
    
    public void GatherEnemyData()
    {
        Console.WriteLine("What is the enemy grid?(8 digit) ");
        _grid = Console.ReadLine();

        Console.WriteLine("What is the direction of the enemy from your location? (mils)");
        _mils = Console.ReadLine();

        Console.WriteLine("What is the altitude change to the enemy?(no less than 30,  count by 5) ");
        _alt = Console.ReadLine();

        Console.WriteLine("What is the enemy description?\n ");
        _desc = Console.ReadLine();
    }

    public void SendCallForFire()
    {
        Console.WriteLine();
        _radio.Transmit("Mamba47","FDC this is Mamba 47 over." );
        _radio.Transmit("Mamba47",$"Grid: {_grid}, Direction: {_mils}, Alt:{_alt}." );
        _radio.Transmit("Mamba47",$"{_desc}" );
        Console.WriteLine();
    }

    

}