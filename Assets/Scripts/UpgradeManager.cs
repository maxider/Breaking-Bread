public static class UpgradeManager{

    public static int JuengerCost = 25;
    public static int MoenchBrokenBreadCost = 50;
    public static int MoenchJuengerCost = 1;

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
