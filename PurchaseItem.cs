using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseItem : MonoBehaviour
{
    public Button thisButton;
    public float cost; //NOTHING SMALLER THAN TEN MILLION. || One Billion = 1 || One Hundred Million = 0.1 || Ten Million = 0.01
    public static int indexCounter = 0; 
    // Start is called before the first frame update
    void Start()
    {
        thisButton = assignlistener(thisButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Button assignlistener(Button button)
    {
        if (this.thisButton.name.Equals("IIWR") || this.thisButton.name.Equals("HC"))
        {
            button.onClick.AddListener(confirmItem);
        }
        else
        {
            button.onClick.AddListener(buyItem);
        }

        return button;
    }

    void buyItem()
    {
        CompanyAssets.companyCash = (float) Math.Round((CompanyAssets.companyCash - cost), 2);
        
    }

    void confirmItem()
    {
  
        if (indexCounter == DecisionTextPopups.decisionTexts.Count)
        {
            CompanyAssets.companyCash = (float)Math.Round((CompanyAssets.companyCash - cost), 2);
        }
        else
        {
            
            DecisionTextPopups.decisionTexts[indexCounter].SetActive(true);
            indexCounter++;
        }
        
    }

    



    
}
