using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;



public class prop : MonoBehaviour
{
    public string item1 = "紅水";
    public string item2 = "藍水";

    [Header("道具")]
    public Text Inventory;
    
    public Text result;

    private void Update()
    {
        if (item1 == "紅水")
        {
            print("回復生命");
        }

    }

}
