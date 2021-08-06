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
        ClockManager.ApplePower += 2;
        ClockManager.TotalPower += 2;
    }

    // On Click RaspberryButton
    public void LevelUpRaspberry()
    {
        RaspberrySound.Play();

        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.RaspberryCost;
        SubmissionManager.BlammedSubmissions += ClockManager.RaspberryCost;

        ClockManager.RaspberryCost *= 2;
        ClockManager.RaspberryPower += 2;
        ClockManager.TotalPower += 2;
    }

    // On Click PineappleButton
    public void LevelUpPineapple()
    {
        PineappleSound.Play();

        ClockSubmitter.SetActive(true);
        SubmissionManager.SavedSubmissions -= ClockManager.PineappleCost;
        SubmissionManager.BlammedSubmissions += ClockManager.PineappleCost;

        ClockManager.PineappleCost *= 2;
        ClockManager.PineapplePower += 2;
        ClockManager.TotalPower += 2;
    }
}
