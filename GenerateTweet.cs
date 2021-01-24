using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GenerateTweet : MonoBehaviour
{
    public static Button thisButton;
    public TextMeshProUGUI tweetText;
    public static bool bookChanged;
    public GameObject FileSelector;
    public GameObject sendTweet;
    public string pastTweet = "Empty"; 
     // Start is called before the first frame update
    void Start()
    {
        thisButton = this.gameObject.GetComponent<Button>();
        thisButton.onClick.AddListener(Generate);
    }

    // Update is called once per frame
    void Update()
    {
        if (FileSelector.activeInHierarchy && bookChanged)
        {
            FileSelector.SetActive(false);
            bookChanged = false;
        }
    }

    void Generate()
    {
        GenerateLikes.newTweet = true;
         if (GetTweetText.currentBook != null)
        {
            sendTweet.SetActive(true);
            if (GetTweetText.currentBook.name.Contains("Antifa"))
            {
                tweetText.color = Color.red;
            }
            else
            {
                tweetText.color = Color.blue;
            }
             
            tweetText.text = GetTweetText.generateText();
            while (tweetText.text.Equals(pastTweet))
            {
                tweetText.text = GetTweetText.generateText();
                Debug.Log("Caught a match!");
            }
            pastTweet = tweetText.text;
        }
         GenerateLikes.countingLikes = false;
    }

     
}
