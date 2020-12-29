using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    public string jobTitle;
    public string companyImportance;
    public string reccomendedPay; 
    private static string essentialWorker = "\"Essential\" Worker ;)";
    private static string someImportance = "Does kinda important work.";
    private static string tenAnHour = "10$/Hr";
    private static string twentyFiveAnHour = "25$/Hr";
    private static string oneHundredAnHour = "100$/Hr";
    private static string OneThouAnHour = "1k$/Hr";
    public static List<Job> jobs = new List<Job>();
    // Start is called before the first frame update

    public Job(string jobTitle, string companyImportance, string reccomendedPay)
    {
        this.jobTitle = jobTitle;
        this.companyImportance = companyImportance;
        this.reccomendedPay = reccomendedPay;
        addToList(this);
       
     }
    void Start()
    {
        
          
    }

    public static void addToList(Job thisJob)
    {
        jobs.Add(thisJob);
         
     }

    public static void createJobs()
    {
        Job cashier = new Job("Cashier", essentialWorker, tenAnHour);
        Job warehouseWorker = new Job("WareHouseWorker", essentialWorker, tenAnHour);
        Job analyst = new Job("Analyst", someImportance, twentyFiveAnHour);
        Job receptionist = new Job("Receptionist", essentialWorker, tenAnHour);
        Job CEO = new Job("CEO", "Sleeps at desk all day.", OneThouAnHour);
        Job projectManager = new Job("Senior Manager", "Completely Obsolete", OneThouAnHour);
    }

    

     
}
