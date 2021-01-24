using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UploadTweet : MonoBehaviour
{
    public GameObject FileSelector;
    public Button thisButton;
    // Start is called before the first frame update
    void Start()
    {
        thisButton = this.gameObject.GetComponent<Button>();
        thisButton.onClick.AddListener(openFiles);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void openFiles()
    {

       
        FileSelector.SetActive(true);
        
    }
}
