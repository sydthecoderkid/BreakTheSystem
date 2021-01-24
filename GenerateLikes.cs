using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GenerateLikes : MonoBehaviour
{
    public TextMeshProUGUI likesText;
    public Button sendTweet;
    public int maxLikeNumber;
    public static bool countingLikes;
    public static int likesCounted;
    public static bool finishedCounting;
    public static bool newTweet; 
    // Start is called before the first frame update
    void Start()
    {
        sendTweet = this.gameObject.GetComponent<Button>();
        sendTweet.onClick.AddListener(Generate);
        newTweet = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if (countingLikes && likesCounted <= maxLikeNumber)
        {
            likesCounted++;
            likesText.text = "Likes: " + likesCounted;
        }
        else if (!countingLikes)
        {
            likesCounted = 0;
            likesText.text = "Likes: ";
        }
        else
        {
            newTweet = false; 
        }

        
        
    }

    void Generate()
    {
        if (newTweet)
        {
            likesCounted = 0;
            maxLikeNumber = 0;
            System.Random rand = new System.Random();
            if (GetTweetText.currentBook.name.Contains("Antifa"))
            {
                maxLikeNumber = 100;
            }
            else
            {
                maxLikeNumber = 50;
            }
            maxLikeNumber = rand.Next(0, maxLikeNumber);
            countingLikes = true;
        }
    }
}
