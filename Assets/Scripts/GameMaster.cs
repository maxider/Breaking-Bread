using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    float counter = 0;

    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 1)
        {
            counter = 0;
            tick();
        }
        CostManager.UpdateCosts();
    }

    public void ResetPlayerInfo()
    {
        PlayerInfo.ResetPlayerInfo();
    }

    void tick()
    {
        AutoGenerator.Tick();
    }
}
