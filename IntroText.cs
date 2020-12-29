using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroText : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public ArrayList messages = new ArrayList();
    public int currentIndex = -1;
    public int characterCounter = 0;
    public string currentMessage;
    public float time = 0;
    public bool typingMessage;
    public float timetoType;
    public float timeToRead = 1f;
    public GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
        loadMessages();
        switchMessage();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (typingMessage)
        {
            if(displayText.text.Length >= currentMessage.Length)
            {
                timeToRead += Time.deltaTime;
                if (timeToRead >= 1 && currentIndex < messages.Count -1)
                {
                    
                    currentIndex++;
                    switchMessage();
                    timeToRead = 0;
                }
                else if(currentIndex >= messages.Count - 1)
                {
                    startButton.SetActive(true);
                }
            }
           else if(time >= timetoType)
            {
                displayText.text += currentMessage[characterCounter];
                characterCounter += 1;
                time = 0;
            }
            
        }
    }

    void loadMessages()
    {
        messages.Add("Welcome...");
        messages.Add("You have proven your skills as a hacker");
        messages.Add("Now it is time to put them to the test");
        messages.Add("Let Us Begin.");
    }

    void switchMessage()
    { 
         
         
            displayText.text = "";
            currentMessage = (string)messages[currentIndex];
            typingMessage = true;
            characterCounter = 0;
        
        
    }
 
}
