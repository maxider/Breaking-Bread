using UnityEngine;

public static class CostManager
{
    static int juengerCost = 25;
    static int moenchCost = 30;

    static float JuengerMult = 1.3f;
    static float MoenchMult = 1.4f;

    static void updateJuengerCost()
    {
        UpgradeManager.JuengerCost = Mathf.RoundToInt(juengerCost * Mathf.Pow(JuengerMult, PlayerInfo.JuengerAmount));
    }

    static void updateMoenchCost()
    {
        UpgradeManager.MoenchBrokenBreadCost = Mathf.RoundToInt(moenchCost * Mathf.Pow(MoenchMult, PlayerInfo.MoenchAmount));
    }

    public static void UpdateCosts()
    {
        updateJuengerCost();
        updateMoenchCost();
    }
}
