using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionTextPopups : MonoBehaviour
{
    public static List<GameObject> decisionTexts = new List<GameObject>(5);
    public GameObject textOne;
    public GameObject textTwo;
    public GameObject textThree;
    public GameObject textFour;
    public GameObject textFive;
    // Start is called before the first frame update
    void Start()
    {
        decisionTexts.Add(textOne);
        decisionTexts.Add(textTwo);
        decisionTexts.Add(textThree);
        decisionTexts.Add(textFour);
        decisionTexts.Add(textFive);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
