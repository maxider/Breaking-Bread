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
