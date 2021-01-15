using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GetTweetText : MonoBehaviour
{
    public static string currentpath;
    public static Book currentBook;
    // Start is called before the first frame update
    void Start()
    {
         
        

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public static void generateText()
    {
        currentpath = currentBook.path;
        Debug.Log(currentpath);
        string[] lines = System.IO.File.ReadAllLines(currentpath);
        System.Random rand = new System.Random();
        Debug.Log((string)lines[rand.Next(0, lines.Length-1)]);

    }
}
