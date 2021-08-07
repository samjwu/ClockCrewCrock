using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockButton : MonoBehaviour
{
    public AudioSource BgmPlayer;
    public AudioClip Milk1;
    public AudioClip Milk2;
    public AudioClip Yer;
    public AudioClip Jam;
    public AudioClip Dreams;

    public AudioSource StrawberrySound;
    public AudioSource OrangeSound;
    public AudioSource RaspberrySound;
    public AudioSource AppleSound;
    public AudioSource PineappleSound;

    public GameObject SubmitButton;
    public GameObject SubmissionName;
    public GameObject InfoDisplay;

    public GameObject StrawberryButton;
    public GameObject OrangeButton;
    public GameObject RaspberryButton;
    public GameObject AppleButton;
    public GameObject PineappleButton;

    private IEnumerator coroutine;

    // On Click StrawberryButton
    public void LevelUpStrawberry()
    {
        StrawberrySound.Play();

        ClockSubmitter.StrawberryOn = true;
        SubmissionManager.SavedSubmissions -= ClockManager.StrawberryCost;
        SubmissionManager.BlammedSubmissions += ClockManager.StrawberryCost;

        ClockManager.StrawberryCost *= 2;
        ClockManager.StrawberryPower += 1;
        ClockManager.TotalPower += 1;

        ClockManager.StrawberryLevel += 1;
        if (ClockManager.StrawberryLevel == ClockManager.LevelThreshold)
        {
            InfoDisplay.GetComponent<Text>().text = StoryText.Story7;
            string secondInfoText = StoryText.Story8;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Orange);
            StartCoroutine(coroutine);
        }
    }

    // On Click OrangeButton
    public void LevelUpOrange()
    {
        OrangeSound.Play();

        ClockSubmitter.OrangeOn = true;
        SubmissionManager.SavedSubmissions -= ClockManager.OrangeCost;
        SubmissionManager.BlammedSubmissions += ClockManager.OrangeCost;

        ClockManager.OrangeCost *= 2;
        ClockManager.OrangePower += 2;
        ClockManager.TotalPower += 2;

        ClockManager.OrangeLevel += 1;
        if (ClockManager.OrangeLevel == ClockManager.LevelThreshold)
        {
            InfoDisplay.GetComponent<Text>().text = StoryText.Story9;
            string secondInfoText = StoryText.Story10;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Raspberry);
            StartCoroutine(coroutine);
        }
    }

    // On Click RaspberryButton
    public void LevelUpRaspberry()
    {
        RaspberrySound.Play();

        ClockSubmitter.RaspberryOn = true;
        SubmissionManager.SavedSubmissions -= ClockManager.RaspberryCost;
        SubmissionManager.BlammedSubmissions += ClockManager.RaspberryCost;

        ClockManager.RaspberryCost *= 2;
        ClockManager.RaspberryPower += 3;
        ClockManager.TotalPower += 3;

        ClockManager.RaspberryLevel += 1;
        if (ClockManager.RaspberryLevel == ClockManager.LevelThreshold)
        {
            InfoDisplay.GetComponent<Text>().text = StoryText.Story11;
            string secondInfoText = StoryText.Story12;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Apple);
            StartCoroutine(coroutine);
        }
    }

    // On Click AppleButton
    public void LevelUpApple()
    {
        AppleSound.Play();

        ClockSubmitter.AppleOn = true;
        SubmissionManager.SavedSubmissions -= ClockManager.AppleCost;
        SubmissionManager.BlammedSubmissions += ClockManager.AppleCost;

        ClockManager.AppleCost *= 2;
        ClockManager.ApplePower += 4;
        ClockManager.TotalPower += 4;

        ClockManager.AppleLevel += 1;
        if (ClockManager.AppleLevel == ClockManager.LevelThreshold)
        {
            InfoDisplay.GetComponent<Text>().text = StoryText.Story13;
            string secondInfoText = StoryText.Story14;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Pineapple);
            StartCoroutine(coroutine);
        }
    }

    // On Click PineappleButton
    public void LevelUpPineapple()
    {
        PineappleSound.Play();

        ClockSubmitter.PineappleOn = true;
        SubmissionManager.SavedSubmissions -= ClockManager.PineappleCost;
        SubmissionManager.BlammedSubmissions += ClockManager.PineappleCost;

        ClockManager.PineappleCost *= 2;
        ClockManager.PineapplePower += 5;
        ClockManager.TotalPower += 5;

        ClockManager.PineappleLevel += 1;
        if (ClockManager.PineappleLevel == ClockManager.LevelThreshold)
        {
            InfoDisplay.GetComponent<Text>().text = StoryText.Story15;
            string secondInfoText = StoryText.Story16;
            string thirdInfoText = StoryText.Story17;
            string fourthInfoText = StoryText.Story18;

            coroutine = SequenceClockStory(secondInfoText, -1);
            StartCoroutine(coroutine);

            coroutine = SequenceClockStory(thirdInfoText, -1);
            StartCoroutine(coroutine);

            coroutine = SequenceClockStory(fourthInfoText, -1);
            StartCoroutine(coroutine);
        }
    }

    public IEnumerator SequenceClockStory(string infoText, int enableType)
    {
        yield return new WaitForSeconds(5);

        switch (enableType)
        {
            case (int)StoryText.EnableTypes.Submit:
                SubmitButton.SetActive(true);
                break;
            case (int)StoryText.EnableTypes.Strawberry:
                StrawberryButton.SetActive(true);
                break;
            case (int)StoryText.EnableTypes.Orange:
                OrangeButton.SetActive(true);
                break;
            case (int)StoryText.EnableTypes.Raspberry:
                RaspberryButton.SetActive(true);
                break;
            case (int)StoryText.EnableTypes.Apple:
                AppleButton.SetActive(true);
                break;
            case (int)StoryText.EnableTypes.Pineapple:
                PineappleButton.SetActive(true);
                break;
            case -1:
                break;
        }

        InfoDisplay.GetComponent<Text>().text = infoText;
    }
}
