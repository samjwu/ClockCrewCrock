using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockLog : MonoBehaviour
{
    public GameObject ClockSubmitter;
    public AudioSource StrawberrySound;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LevelUpStrawberry()
    {
        StrawberrySound.Play();

        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.StrawberryCost;
        SubmissionManager.BlammedSubmissions += ClockManager.StrawberryCost;

        ClockManager.StrawberryCost *= 2;
        ClockManager.StrawberryPower += 1;
        ClockManager.TotalPower += 1;
    }
}
