using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockLog : MonoBehaviour
{
    public GameObject ClockSubmitter;
    public AudioSource StrawberrySound;
    public AudioSource OrangeSound;
    public AudioSource AppleSound;
    public AudioSource RaspberrySound;
    public AudioSource PineappleSound;

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

        ClockManager.StrawberryLevel += 1;
        if (ClockManager.StrawberryLevel == 5)
        {
            // TODO
        }
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

    // On Click AppleButton
    public void LevelUpApple()
    {
        AppleSound.Play();

        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.AppleCost;
        SubmissionManager.BlammedSubmissions += ClockManager.AppleCost;

        ClockManager.AppleCost *= 2;
        ClockManager.ApplePower += 3;
        ClockManager.TotalPower += 3;
    }

    // On Click RaspberryButton
    public void LevelUpRaspberry()
    {
        RaspberrySound.Play();

        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.RaspberryCost;
        SubmissionManager.BlammedSubmissions += ClockManager.RaspberryCost;

        ClockManager.RaspberryCost *= 2;
        ClockManager.RaspberryPower += 4;
        ClockManager.TotalPower += 4;
    }

    // On Click PineappleButton
    public void LevelUpPineapple()
    {
        PineappleSound.Play();

        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.PineappleCost;
        SubmissionManager.BlammedSubmissions += ClockManager.PineappleCost;

        ClockManager.PineappleCost *= 2;
        ClockManager.PineapplePower += 5;
        ClockManager.TotalPower += 5;
    }
}
