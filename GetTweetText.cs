using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GetTweetText : MonoBehaviour
{
    public static ArrayList paths = new ArrayList();
    public string currentpath;
    // Start is called before the first frame update
    void Start()
    {
        paths.Add(@"\Assets\BookTextFiles\1001CorporateTweets.txt");
        paths.Add(@"\Assets\BookTextFiles\ANTIFAHANDBOOK.txt");
        System.Random rand = new System.Random();
        currentpath = (string)paths[rand.Next(0, paths.Count)];
        generateText(currentpath);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void generateText(string path)
    {
        Debug.Log(path);
    }
}
