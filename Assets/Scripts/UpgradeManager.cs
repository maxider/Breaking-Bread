public static class UpgradeManager{

    public static int JuengerCost;
    public static int MoenchBrokenBreadCost;
    public static int MoenchJuengerCost;

    public static void buyJuenger()
    {
        if (PlayerInfo.BrokenBreadAmount >= JuengerCost)
        {
            PlayerInfo.BrokenBreadAmount -= JuengerCost;
            PlayerInfo.JuengerAmount++;
        }
    }

    public static void buyMoench()
    {
        if (PlayerInfo.BrokenBreadAmount >= MoenchBrokenBreadCost && PlayerInfo.JuengerAmount >= MoenchJuengerCost)
        {
            PlayerInfo.BrokenBreadAmount -= MoenchBrokenBreadCost;
            PlayerInfo.JuengerAmount -= MoenchJuengerCost;
            PlayerInfo.MoenchAmount++;
        }
    }
}
