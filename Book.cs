using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    public string path;
    public Sprite sprite;
    public CurrentBook thisBooksCurrent;
    public Button thisButton;
    public GameObject thisObject;
    // Start is called before the first frame update
    void Start()
    {
        thisButton.onClick.AddListener(setBook);
        thisBooksCurrent = new CurrentBook();
    }

    // Update is called once per frame
    void Update()
    { 
    }

    void setBook()
    {
        thisBooksCurrent.changeBook(thisObject);
        
    }

    
}
