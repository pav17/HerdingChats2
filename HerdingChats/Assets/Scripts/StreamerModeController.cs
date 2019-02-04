using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreamerModeController : MonoBehaviour
{
    public Text streamerModeButtontext;

    void Start()
    {
        streamerModeButtontext.text = "Streamer Mode: ON";
    }

    
    public void ToggleStreamerMode()
    {
        if(Global.Instance.streamerMode == true)
        {
            Global.Instance.streamerMode = false;
            streamerModeButtontext.text = "Streamer Mode: OFF";
        }
        else if (Global.Instance.streamerMode == false)
        {
            Global.Instance.streamerMode = true;
            streamerModeButtontext.text = "Streamer Mode: ON";
        }
    }
}
