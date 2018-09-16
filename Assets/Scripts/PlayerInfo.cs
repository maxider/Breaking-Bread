using UnityEngine;

public static class PlayerInfo
{
    public static int BreadAmount = 10;
    public static int BrokenBreadAmount;
    public static int GoldAmount;
    public static int JuengerAmount;
    public static int MoenchAmount;

    public static void ResetPlayerInfo()
    {
        BreadAmount = 10;
        BrokenBreadAmount = 0;
        GoldAmount = 0;
        JuengerAmount = 0;
        MoenchAmount = 0;
        Debug.Log("Reset completed");
    }
}