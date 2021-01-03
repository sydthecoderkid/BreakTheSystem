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
        thisButton.onClick.AddListener(switchSlide);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    void switchSlide()
    {
        nextSlide.SetActive(true);
        thisSlide.SetActive(false);
    }
}
