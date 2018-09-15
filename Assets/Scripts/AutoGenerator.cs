using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenerator : MonoBehaviour
{
    public static int BPS;

    public int JuengerFarmRate = 1;
    float counter = 0;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 1)
        {
            counter = 0;
            tick();
        }
        updateBPS();
    }

    void tick()
    {
        PlayerInfo.BrokenBreadAmount += BPS;
    }

    void updateBPS()
    {
        BPS = JuengerFarmRate * PlayerInfo.JuengerAmount;
    }
}
