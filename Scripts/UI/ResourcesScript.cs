using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesScript : MonoBehaviour
{
    public int metall;
    public int wood;
    public int houney;
    public Text metallText;
    public Text woodText; 
    public Text houneyText;

    private void Start()
    {
        metallText.text = "Metall: " + metall.ToString();

        woodText.text = "Wood: " + wood.ToString();

        houneyText.text = "Houney: " + houney.ToString();
    }
     
    public void MetallPlus(int plusMetallCount) => metall += plusMetallCount;

    public void WoodPlus(int plusWoodCount) => wood += plusWoodCount;

    public void HouneyPlus(int plusHouneyCount) => houney += plusHouneyCount;

    private void Update()
    {
        metallText.text = "Metall: " + metall.ToString();

        woodText.text = "Wood: " + wood.ToString();

        houneyText.text = "Houney: " + houney.ToString();
    }
}
