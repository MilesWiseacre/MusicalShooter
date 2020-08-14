using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_SeqButton : MonoBehaviour {

    public bool active;

    private void Awake()
    {
        active = false;
        GetComponent<Image>().color = Color.gray;
    }

    public void ToggleBeat()
    {
        if (active)
        {
            active = false;
            GetComponent<Image>().color = Color.gray;
        }
        else
        {
            active = true;
            GetComponent<Image>().color = Color.white;
        }
    }
}
