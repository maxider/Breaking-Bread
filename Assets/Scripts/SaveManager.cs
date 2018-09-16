using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        load();
    }

    void OnApplicationQuit()
    {
        save();
    }

    void save()
    {
        PlayerPrefs.SetInt("BreadAmount", PlayerInfo.BreadAmount);
        PlayerPrefs.SetInt("BrokenBreadAmount", PlayerInfo.BrokenBreadAmount);
        PlayerPrefs.SetInt("GoldAmount", PlayerInfo.GoldAmount);
        PlayerPrefs.SetInt("JuengerAmount", PlayerInfo.JuengerAmount);
        PlayerPrefs.SetInt("MoenchAmount", PlayerInfo.MoenchAmount);


        Debug.Log("Saved Player Info");
    }

    void load()
    {
        if (PlayerPrefs.HasKey("BreadAmount"))
        {
            PlayerInfo.BreadAmount = PlayerPrefs.GetInt("BreadAmount");
            PlayerInfo.BrokenBreadAmount = PlayerPrefs.GetInt("BrokenBreadAmount");
            PlayerInfo.GoldAmount = PlayerPrefs.GetInt("GoldAmount");
            PlayerInfo.JuengerAmount = PlayerPrefs.GetInt("JuengerAmount");
            PlayerInfo.MoenchAmount = PlayerPrefs.GetInt("MoenchAmount");


            Debug.Log("loaded save");
        }
        else
        {
            Debug.Log("No key with name: \"BreadAmount\" found");
        }
    }
}
