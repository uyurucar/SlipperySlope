using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoplay : MonoBehaviour
{
    public GameObject img;
    public void HowToButton()
    {
        if(img.activeSelf) img.SetActive(false);
        else
            img.SetActive(true);
    }
}
