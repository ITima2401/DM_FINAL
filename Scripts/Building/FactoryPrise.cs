using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactoryPrise : MonoBehaviour
{
    private void Awake()
    {
        GameObject.Find("Plane").GetComponent<BuildingsGrid>().priseMet = GameObject.Find("FactoryButton").GetComponent<BuyFactory>().FactoryPriseMet;
        GameObject.Find("Plane").GetComponent<BuildingsGrid>().priseWd = GameObject.Find("FactoryButton").GetComponent<BuyFactory>().FactoryPriseWd;
        GameObject.Find("Plane").GetComponent<BuildingsGrid>().priseHn = GameObject.Find("FactoryButton").GetComponent<BuyFactory>().FactoryPriseHn;
    }

}
