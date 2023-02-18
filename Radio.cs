using System;

/* Transmits messages back and forth between the FO and FDC
*/
public class Radio
{
    public void Transmit(string sender, string message)
    {
        Console.WriteLine($"{sender}: {message} ");
    }
}


