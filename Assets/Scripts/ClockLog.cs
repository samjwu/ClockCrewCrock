using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockLog : MonoBehaviour
{
    public GameObject ClockSubmitter;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartClockSubmitter()
    {
        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.StrawberryCost;
        SubmissionManager.BlammedSubmissions += ClockManager.StrawberryCost;
        ClockManager.StrawberryCost *= 2;
    }
}
