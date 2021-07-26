using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndToSplash : MonoBehaviour
{
    public GameObject AgainButton;

    public void PlayAgain()
    {
        SubmissionButton.SeenBHistory = false;

        ClockManager.StrawberryCost = 1;
        ClockManager.StrawberryPower = 0;

        ClockManager.OrangeCost = 2;
        ClockManager.OrangePower = 0;

        ClockManager.RaspberryCost = 4;
        ClockManager.RaspberryPower = 0;

        ClockManager.AppleCost = 8;
        ClockManager.ApplePower = 0;

        ClockManager.PineappleCost = 16;
        ClockManager.PineapplePower = 0;

        ClockManager.LevelThreshold = 10;
        ClockManager.StrawberryLevel = 0;
        ClockManager.OrangeLevel = 0;
        ClockManager.AppleLevel = 0;
        ClockManager.RaspberryLevel = 0;
        ClockManager.PineappleLevel = 0;
        ClockManager.TotalPower = 1;

        ClockSubmitter.StrawberryOn = false;
        ClockSubmitter.StrawberryCreating = false;

        ClockSubmitter.OrangeOn = false;
        ClockSubmitter.OrangeCreating = false;

        ClockSubmitter.RaspberryOn = false;
        ClockSubmitter.RaspberryCreating = false;

        ClockSubmitter.AppleOn = false;
        ClockSubmitter.AppleCreating = false;

        ClockSubmitter.PineappleOn = false;
        ClockSubmitter.PineappleCreating = false;

        SubmissionManager.BlammedSubmissions = 0;
        SubmissionManager.SavedSubmissions = 0;

        SceneManager.LoadScene(1);
    }
}
