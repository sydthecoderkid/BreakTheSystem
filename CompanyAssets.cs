using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompanyAssets : MonoBehaviour
{
    public static float companyCash = 600;
    public TextMeshProUGUI cashText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cashText.text = "Total Company Cash: " + companyCash + " Billion";
    }
}
