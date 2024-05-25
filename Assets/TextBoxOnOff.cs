using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxOnOff : MonoBehaviour
{
    public GameObject tb1;
    public GameObject tb2;
    public bool onoff;

    void start()
    {
        onoff = true;
    }

    void Update()
    {
        if (onoff)
        {
            tb1.SetActive(true);
            tb2.SetActive(true);
        }
        else
        {
            tb1.SetActive(false);
            tb2.SetActive(false);
        }
    }
}
