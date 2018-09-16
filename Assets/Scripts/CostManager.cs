using UnityEngine;


public static class CostManager
{
    static int juengerCost = 25;
    static int moenchCost = 30;

    static float JuengerMult = 1.3f;
    static float MoenchMult = 1.4f;

    public static void UpdateJuengerCost()
    {
        UpgradeManager.JuengerCost = Mathf.RoundToInt(juengerCost * Mathf.Pow(JuengerMult, PlayerInfo.JuengerAmount));
    }

    public static void UpdateMoenchCost()
    {
        UpgradeManager.MoenchBrokenBreadCost = Mathf.RoundToInt(moenchCost * Mathf.Pow(MoenchMult, PlayerInfo.MoenchAmount));
    }
}
