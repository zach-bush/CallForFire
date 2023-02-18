public class Program
{
    public static void Main(string[] args)
    {
        FO fo = new FO();
        fo.GatherEnemyData();
        fo.SendCallForFire();

        FDC fdc = new FDC();
        fdc.SendMTO();

        Spotting spot = new Spotting();
        spot.CallSpotting();
        spot.SendSpotting();

        Adjustment adjust = new Adjustment();
        adjust.AdjustmentPhase();
        adjust.SendAdjustments();

        EOM eom = new EOM();
        eom.EndOfMissionStatement();
        eom.SendEOM(); 

    }
}
