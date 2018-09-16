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
        PlayerPrefs.SetInt("BreadAmount", PlayerInfo.BrokenBreadAmount);
        PlayerPrefs.SetInt("GoldAmount", PlayerInfo.GoldAmount);
        PlayerPrefs.SetInt("JuengerAmount", PlayerInfo.JuengerAmount);
        PlayerPrefs.SetInt("MoenchAmount", PlayerInfo.MoenchAmount);


        Debug.Log("Saved Player Info");
    }

    void load()
    {
        if (PlayerPrefs.HasKey("BreadAmount"))
        {
            PlayerInfo.BrokenBreadAmount = PlayerPrefs.GetInt("BreadAmount");
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
