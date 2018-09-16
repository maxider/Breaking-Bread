using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text BreadText;
    int initBreadTextLen;
    public Text BPSText;
    int initBPSTextLen;

    public Text BreakingText;
    int initBreakingTextLen;
    public Text BBPSText;
    int initBBPSTextLen;

    public Text GoldText;
    int initGoldTextLen;
    public Text GPSText;
    int initGPSText;


    public Text JuengerText;
    int initJuengerTextLen;
    public Text JuengerPriceText;


    public Text MoenchText;
    int initMoenchTextLen;
    public Text MoenchPriceText;

    // Use this for initialization
    void Start()
    {
        initBreadTextLen = BreadText.text.Length;
        initBPSTextLen = BPSText.text.Length;

        initBreakingTextLen = BreakingText.text.Length;
        initBBPSTextLen = BBPSText.text.Length;

        initGoldTextLen = GoldText.text.Length;
        initGPSText = GPSText.text.Length;

        initJuengerTextLen = JuengerText.text.Length;

        initMoenchTextLen = MoenchText.text.Length;
    }

    // Update is called once per frame
    void Update()
    {
        updateText(BreadText, initBreadTextLen, PlayerInfo.BreadAmount);
        updateText(BPSText, initBPSTextLen, AutoGenerator.BPS);

        updateText(BreakingText, initBreakingTextLen, PlayerInfo.BrokenBreadAmount);
        updateText(BBPSText, initBPSTextLen, AutoGenerator.BBPS);

        updateText(GoldText, initGoldTextLen, PlayerInfo.GoldAmount);
        updateText(GPSText, initGoldTextLen, AutoGenerator.GPS);
        
        updateText(JuengerText, initJuengerTextLen, PlayerInfo.JuengerAmount);
        updateText(JuengerPriceText, 0, UpgradeManager.JuengerCost);

        updateText(MoenchText, initMoenchTextLen, PlayerInfo.MoenchAmount);
        updateText(MoenchPriceText, 0, UpgradeManager.MoenchBrokenBreadCost);
    }

    void updateText(Text text, int len, int value)
    {
        text.text = text.text.Substring(0, len) + value.ToString();
    }
}
