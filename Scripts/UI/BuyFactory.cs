using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFactory : MonoBehaviour
{
    public int FactoryPriseMet;
    public int FactoryPriseWd;
    public int FactoryPriseHn;
    private int metall;
    private int wood;
    private int houney;
    private void Update()
    {
        metall = GameObject.Find("Resources").GetComponent<ResourcesScript>().metall;
        wood = GameObject.Find("Resources").GetComponent<ResourcesScript>().wood;
        houney = GameObject.Find("Resources").GetComponent<ResourcesScript>().houney;

        if (metall >= FactoryPriseMet && wood >= FactoryPriseWd && houney >= FactoryPriseHn)
        {
            GameObject.Find("FactoryButton").GetComponent<Button>().interactable = true;

        }
        else
        {
            GameObject.Find("FactoryButton").GetComponent<Button>().interactable = false;
        }
    }
    
}
