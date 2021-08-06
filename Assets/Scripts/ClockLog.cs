using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockLog : MonoBehaviour
{
    public GameObject ClockSubmitter;
    public AudioSource StrawberrySound;
    public AudioSource OrangeSound;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // On Click StrawberryButton
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

    // On Click OrangeButton
    public void LevelUpOrange()
    {
        OrangeSound.Play();

        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.OrangeCost;
        SubmissionManager.BlammedSubmissions += ClockManager.OrangeCost;

        ClockManager.OrangeCost *= 2;
        ClockManager.OrangePower += 2;
        ClockManager.TotalPower += 2;
    }
}
