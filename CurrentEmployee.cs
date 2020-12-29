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
    // Start is called before the first frame update
    void Start()
    {
        currentEmployee = new Employee();
        currentEmployee.job = currentEmployee.generateJob();
    }

    // Update is called once per frame
    void Update()
    {
        
            employeeName.text = "Name: " + currentEmployee.employeeName;
            jobTitle.text = "Job Title: " + currentEmployee.job.jobTitle;
            companyImportance.text = "Company Role: " + currentEmployee.job.companyImportance;
             reccomendedPay.text = "Reccomended Pay: " + currentEmployee.job.reccomendedPay;
    }
}
