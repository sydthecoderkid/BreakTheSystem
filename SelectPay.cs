using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectPay : MonoBehaviour
{

    public Button thisButton;
    public static TextMeshProUGUI payText;
    public GameObject confirm;
    public static GameObject currentEmployeeCard;
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
        button.onClick.AddListener(setPay);

        return button;
    }

    void setPay()
    {
        payText = currentEmployeeCard.GetComponent<CurrentEmployee>().hourlypay;
        payText.text = "Hourly Pay: " + this.GetComponent<TextMeshProUGUI>().text;
        confirm.SetActive(true);
    }
}
