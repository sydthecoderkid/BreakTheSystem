using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee : MonoBehaviour
{
    public string employeeName;
    public Job job;

    public List<string> names = new List<string>() {
        "John Doe",
         "Katy Darrit",
         "Layla Lutz",
         "Lilly Downes",
         "Nelson Stott",
         "Elora Parra",
         "Avi Pratt",
        "Kirk Dalton",
        "Nicholas James",
        "Janine Lowrey",
        "Feddie Keller",
        "Ronan Carroll",
        "Brianna Owen",
        "Nancy Crawford",
        "Jane Doe",
        "Maria Roche",
        "Brittany Owen",
        "Henley Ware",

    };


    // Start is called before the first frame update

    

    void Start()
    {

        Job.createJobs();
       

    }

    public Employee()
    {
        this.employeeName = generateName();
        //Do not generate a job here! Straight up does not work- something about the order these files are called.

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string generateName()
    {
        System.Random rand = new System.Random();
        int randomNameNumber = rand.Next(0, names.Count - 1);
        return names[randomNameNumber];
    }

    public Job generateJob()
    {
        System.Random rand = new System.Random();
        int randomNameNumber = rand.Next(0, Job.jobs.Count - 1);
         return Job.jobs[randomNameNumber];
    }
}
