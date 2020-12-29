using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextSlide : MonoBehaviour
{
    public GameObject nextSlide;
    public GameObject thisSlide;
    public Button thisButton;
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
        button.onClick.AddListener(switchSlide);

        return button;
    }

    void switchSlide()
    {
        nextSlide.SetActive(true);
        thisSlide.SetActive(false);
    }
}
