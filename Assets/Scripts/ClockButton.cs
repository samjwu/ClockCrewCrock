using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClockButton : MonoBehaviour
{
    public AudioSource Narrator;
    public AudioClip N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20;

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

    public static bool ClocksMuted = false;
    public GameObject MuteClocksButton;

    public GameObject StrawberryButton;
    public GameObject OrangeButton;
    public GameObject RaspberryButton;
    public GameObject AppleButton;
    public GameObject PineappleButton;

    private IEnumerator coroutine;

    // OnClick Quiet Clocks
    public void MuteClocks()
    {
        if (ClocksMuted == false)
        {
            StrawberrySound.volume = 0;
            OrangeSound.volume = 0;
            RaspberrySound.volume = 0;
            AppleSound.volume = 0;
            PineappleSound.volume = 0;
            ClocksMuted = true;
            MuteClocksButton.GetComponent<Image>().color = Color.red;
            MuteClocksButton.GetComponentInChildren<Text>().text = "Speak up, Clocks!";
        } 
        else
        {
            StrawberrySound.volume = 100;
            OrangeSound.volume = 100;
            RaspberrySound.volume = 100;
            AppleSound.volume = 100;
            PineappleSound.volume = 100;
            ClocksMuted = false;
            MuteClocksButton.GetComponent<Image>().color = Color.blue;
            MuteClocksButton.GetComponentInChildren<Text>().text = "Quiet, Clocks!";
        }
    }

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
            BgmPlayer.clip = Milk2;
            BgmPlayer.Play();

            InfoDisplay.GetComponent<Text>().text = StoryText.Story7;
            string secondInfoText = StoryText.Story8;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Orange, N7, N8);
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
            BgmPlayer.clip = Yer;
            BgmPlayer.Play();

            InfoDisplay.GetComponent<Text>().text = StoryText.Story9;
            string secondInfoText = StoryText.Story10;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Raspberry, N9, N10);
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
            BgmPlayer.clip = Jam;
            BgmPlayer.Play();

            InfoDisplay.GetComponent<Text>().text = StoryText.Story11;
            string secondInfoText = StoryText.Story12;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Apple, N11, N12);
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
            BgmPlayer.clip = Dreams;
            BgmPlayer.Play();

            InfoDisplay.GetComponent<Text>().text = StoryText.Story13;
            string secondInfoText = StoryText.Story14;

            coroutine = SequenceClockStory(secondInfoText, (int)StoryText.EnableTypes.Pineapple, N13, N14);
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
            string fifthInfoText = StoryText.Story19;
            string sixthInfoText = StoryText.Story20;

            coroutine = SequenceClockStory(secondInfoText, -1, N15, N16);
            StartCoroutine(coroutine);

            coroutine = ContinueClockStory(thirdInfoText, N17);
            StartCoroutine(coroutine);

            coroutine = ContinueClockStory(fourthInfoText, N18);
            StartCoroutine(coroutine);

            coroutine = ContinueClockStory(fifthInfoText, N19);
            StartCoroutine(coroutine);

            coroutine = ContinueClockStory(sixthInfoText, N20);
            StartCoroutine(coroutine);

            coroutine = EndGame();
            StartCoroutine(coroutine);
        }
    }

    public IEnumerator SequenceClockStory(string infoText, int enableType, AudioClip clip1, AudioClip clip2)
    {
        Narrator.clip = clip1;
        Narrator.Play();

        yield return new WaitWhile(() => Narrator.isPlaying);

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

        Narrator.clip = clip2;
        Narrator.Play();
    }

    public IEnumerator ContinueClockStory(string infoText, AudioClip clip1)
    {
        yield return new WaitWhile(() => Narrator.isPlaying);

        InfoDisplay.GetComponent<Text>().text = infoText;

        Narrator.clip = clip1;
        Narrator.Play();
    }

    public IEnumerator EndGame()
    {
        yield return new WaitWhile(() => Narrator.isPlaying);
        SceneManager.LoadScene(0);
    }
}
