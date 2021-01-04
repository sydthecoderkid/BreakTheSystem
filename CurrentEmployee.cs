using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CurrentEmployee : MonoBehaviour
{
    public Employee currentEmployee;
    public TextMeshProUGUI employeeName;
    public TextMeshProUGUI jobTitle;
    public TextMeshProUGUI companyImportance;
    public TextMeshProUGUI reccomendedPay;
    public TextMeshProUGUI hourlypay;
    public TextMeshProUGUI employeeCount;
    public static int employeeNumber;
     // Start is called before the first frame update
    void Start()
    {
        currentEmployee = new Employee();
        currentEmployee.job = currentEmployee.generateJob(); //This line works here, but not in create employee. 
        SelectPay.currentEmployeeCard = this.gameObject;
        Counter.currentEmployeeCard = this.gameObject;
        employeeNumber += 1;
 
    }

    // Update is called once per frame
    void Update()
    {
        
            employeeName.text = "Name: " + currentEmployee.employeeName;
            jobTitle.text = "Job Title: " + currentEmployee.job.jobTitle;
            companyImportance.text = "Company Role: " + currentEmployee.job.companyImportance;
             reccomendedPay.text = "Reccomended Pay: " + currentEmployee.job.reccomendedPay;
             employeeCount.text = employeeNumber + "/ 10 Employees";
              

    }

    public void test()
    {
        if (employeeNumber >= 10)
        {
            Counter.finish();
            Destroy(SelectPay.currentEmployeeCard);

        }
        else
        {
            CreateEmployee.newEmployeeNeeded = true;
        }
    }
}
