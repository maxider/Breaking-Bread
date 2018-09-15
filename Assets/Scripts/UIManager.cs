using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text BreakingText;
    int initBreakingTextLen;

    public Text JuengerText;
    int initJuengerTextLen;
    public Text JuengerPriceText;

    public Text BPSText;
    int initBPSTextLen;

    public Text MoenchText;
    int initMoenchTextLen;

    // Use this for initialization
    void Start()
    {
        initBreakingTextLen = BreakingText.text.Length;
        initJuengerTextLen = JuengerText.text.Length;
        initBPSTextLen = BPSText.text.Length;
        initMoenchTextLen = MoenchText.text.Length;
    }

    // Update is called once per frame
    void Update()
    {
        updateText(BreakingText, initBreakingTextLen, PlayerInfo.BrokenBreadAmount);
        updateText(JuengerText, initJuengerTextLen, PlayerInfo.JuengerAmount);
        updateText(MoenchText, initMoenchTextLen, PlayerInfo.MoenchAmount);
        updateText(BPSText, initBPSTextLen, AutoGenerator.BPS);
        updateText(JuengerPriceText, 0, UpgradeManager.JuengerCost);
    }

    void updateText(Text text, int len, int value)
    {
        text.text = text.text.Substring(0, len) + value.ToString();
    }
}
