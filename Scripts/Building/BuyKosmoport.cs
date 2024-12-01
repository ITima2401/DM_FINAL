using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyKosmoport : MonoBehaviour
{
    public int KosmoportPriseMet;
    public int KosmoportPriseWd;
    public int KosmoportPriseHn;
    private int metall;
    private int wood;
    private int houney;
    private void Update()
    {
        metall = GameObject.Find("Resources").GetComponent<ResourcesScript>().metall;
        wood = GameObject.Find("Resources").GetComponent<ResourcesScript>().wood;
        houney = GameObject.Find("Resources").GetComponent<ResourcesScript>().houney;

        if (metall >= KosmoportPriseMet && wood >= KosmoportPriseWd && houney >= KosmoportPriseHn)
        {
            GameObject.Find("KosmoportButton").GetComponent<Button>().interactable = true;

        }
        else
        {
            GameObject.Find("KosmoportButton").GetComponent<Button>().interactable = false;
        }
    }

}
