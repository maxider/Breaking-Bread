using UnityEngine;


public static class CostManager
{

    public static void UpdateJuengerCost()
    {
        UpgradeManager.JuengerCost = Mathf.RoundToInt(25f * Mathf.Pow(1.3f, PlayerInfo.JuengerAmount));
    }
}
