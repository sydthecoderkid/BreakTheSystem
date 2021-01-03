using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateEmployee : MonoBehaviour
{
    public GameObject employeeCard;
    public GameObject canvas;
    public static bool firstCard = true;
    public static bool newEmployeeNeeded;
    public static bool employeeCreated;


    // Start is called before the first frame update
    void Start()
    {
        if (firstCard)
        {
            Instantiate(employeeCard, canvas.transform);
            firstCard = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (newEmployeeNeeded)
        {
            createEmployer();
        }
    }


    public void createEmployer()
    {
        Destroy(SelectPay.currentEmployeeCard);
        SelectPay.currentEmployeeCard = Instantiate(employeeCard, canvas.transform);
        newEmployeeNeeded = false;
        employeeCreated = true;
    }




}
