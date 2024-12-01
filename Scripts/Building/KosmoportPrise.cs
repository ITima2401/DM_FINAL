using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KosmoportPrise : MonoBehaviour
{
    private void Awake()
    {
        GameObject.Find("Plane").GetComponent<BuildingsGrid>().priseMet = GameObject.Find("KosmoportButton").GetComponent<BuyKosmoport>().KosmoportPriseMet;
        GameObject.Find("Plane").GetComponent<BuildingsGrid>().priseWd = GameObject.Find("KosmoportButton").GetComponent<BuyKosmoport>().KosmoportPriseWd;
        GameObject.Find("Plane").GetComponent<BuildingsGrid>().priseHn = GameObject.Find("KosmoportButton").GetComponent<BuyKosmoport>().KosmoportPriseHn;
    }

}
