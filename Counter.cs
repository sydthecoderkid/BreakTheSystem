using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static GameObject currentEmployeeCard;
    public static GameObject buttons;
    public static GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        buttons = GameObject.Find("Canvas/Buttons");
        text = GameObject.Find("Canvas/CenterText");
        text.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void finish()
    {
        text.SetActive(true);
        buttons.SetActive(false);
    }


}
