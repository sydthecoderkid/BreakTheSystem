using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConfirmEmployee : MonoBehaviour
{
    public GameObject currentEmployeeCard;
    public Button thisbutton;
    public GameObject employeeObject;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        currentEmployeeCard = SelectPay.currentEmployeeCard;
        thisbutton = this.gameObject.GetComponent<Button>();
        thisbutton.onClick.AddListener(confirm); 
    }

    // Update is called once per frame
    void Update()
    {
        if (CreateEmployee.employeeCreated)
        {
            reassign();
        }
    }

    public void confirm()
    {
        currentEmployeeCard.GetComponent<Animator>().Play("SlideOut");
        this.gameObject.SetActive(false);
    }

     public void reassign()
    {
        currentEmployeeCard = SelectPay.currentEmployeeCard;
        CreateEmployee.employeeCreated = false;
      
    }


}
