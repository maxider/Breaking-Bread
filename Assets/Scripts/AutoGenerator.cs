using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenerator : MonoBehaviour
{
    public static int BPS;

    public static int JuengerFarmRate = 1;


    public static void updateBPS()
    {
        BPS = JuengerFarmRate * PlayerInfo.JuengerAmount;
    }

    public static void Tick()
    {
        updateBPS();
        PlayerInfo.BrokenBreadAmount += BPS;
    }
}
