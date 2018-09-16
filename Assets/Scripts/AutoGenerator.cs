using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenerator : MonoBehaviour
{
    public static int BPS;
    public static int BBPS;
    public static int GPS;

    public static int JuengerFarmRate = 1;
    public static int MoenchFarmRate = 1;

    static void breakBread()
    {
        for (int i = 0; i < PlayerInfo.JuengerAmount; i++)
        {
            if(PlayerInfo.BreadAmount > 0)
            {
                PlayerInfo.BreadAmount--;
                PlayerInfo.BrokenBreadAmount += JuengerFarmRate;
            }
        }
    }

    static void sellBread()
    {
        for (int i = 0; i < PlayerInfo.MoenchAmount; i++)
        {
            if (PlayerInfo.BrokenBreadAmount > 0)
            {
                PlayerInfo.BrokenBreadAmount--;
                PlayerInfo.GoldAmount += MoenchFarmRate;
            }
        }
    }

    static void updateBPS()
    {

    }

    static void updateBBPS()
    {
        BBPS = JuengerFarmRate * PlayerInfo.JuengerAmount;
    }

    static void updateGPS()
    {
        GPS = MoenchFarmRate * PlayerInfo.MoenchAmount;
    }

    public static void Tick()
    {
        updateBPS();
        updateBBPS();
        updateGPS();
        breakBread();
        sellBread();
    }
}
