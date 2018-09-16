using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public GameObject Canvas;
    Animator canvasAnimator;
    bool shopOpen = false;

    void Start()
    {
        canvasAnimator = Canvas.GetComponent<Animator>();
    }

    public void buyJuenger()
    {
        UpgradeManager.buyJuenger();
    }

    public void buyMoench()
    {
        UpgradeManager.buyMoench();
    }

    public void BuyBread()
    {
        if(PlayerInfo.GoldAmount > 0)
        {
            PlayerInfo.BreadAmount += 2;
            PlayerInfo.GoldAmount--;
        }
    }

    public void SellBrokenBread()
    {
        if(PlayerInfo.BrokenBreadAmount > 0)
        {
            PlayerInfo.BrokenBreadAmount--;
            PlayerInfo.GoldAmount++;
        }
    }


    public void ShopButton()
    {
        if (!shopOpen) //Shop Closed
        {
            //SidePanelManager.ShiftLeft(Canvas);
            shopOpen = true;
            canvasAnimator.SetBool("ShopOpen", shopOpen);
        }
        else // If shop is already open
        {
            //SidePanelManager.ResetUIPosition(Canvas);
            shopOpen = false;
            canvasAnimator.SetBool("ShopOpen", shopOpen);
        }
    }

}
