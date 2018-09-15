using UnityEngine;

public static class PlayerInfo
{
    public static int BrokenBreadAmount;
    public static int JuengerAmount;
    public static int MoenchAmount;

    public static void ResetPlayerInfo()
    {
        BrokenBreadAmount = 0;
        JuengerAmount = 0;
        MoenchAmount = 0;
        Debug.Log("Reset completed");
    }
}