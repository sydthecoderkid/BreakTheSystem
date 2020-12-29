using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateEmployee : MonoBehaviour
{
    public GameObject employeeCard;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(employeeCard, canvas.transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
