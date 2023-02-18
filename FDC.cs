using System;

// The FDC takes the information transmitted from the FO and generates an MTO statement
//(in this example MTO will be hard coded), then sends it back to the FO. FDC will then recieve any adjustments 
//from FO and implement them.

public class FDC
{
    private Radio _radio = new Radio();

    public string _mto = "Bulldogs, 1 round, Quick in Effect, target number NS1001 over.";
    
    public void SendMTO()
    {
        Console.WriteLine();
        _radio.Transmit("Steel Rain01", $"{_mto}");
    }


}