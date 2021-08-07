using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmissionButton : MonoBehaviour
{
    public static bool SeenBHistory = false;

    public GameObject TitleDisplay;
    public GameObject SubmitButton;
    public GameObject SubmissionName;
    public GameObject StatusDisplay;

    public GameObject SavedDisplay;
    public AudioSource SaveSound;
    public GameObject BlammedDisplay;
    public AudioSource BlamSound;
    public GameObject ChanceDisplay;

    public GameObject StrawberryButton;
    public GameObject OrangeButton;
    public GameObject AppleButton;
    public GameObject RaspberryButton;
    public GameObject PineappleButton;

    public GameObject InfoDisplay;
    private const float InfoAnimationLength = 7f;

    private IEnumerator coroutine;

    void Start()
    {
        InfoDisplay.GetComponent<Text>().text = StoryText.Story1;
        string secondInfoText = StoryText.Story2;

        coroutine = SequenceAnimations("A", secondInfoText, (int)StoryText.EnableTypes.Submit);
        StartCoroutine(coroutine);
    }

    public void CreatedSubmission()
    {
        SubmissionManager.SentSubmissions++;

        if (SubmissionName.GetComponent<Text>().text == "A")
        {
            TitleDisplay.SetActive(true);
            StatusDisplay.SetActive(true);
            StatusDisplay.GetComponent<Text>().text = "Your submission just got\nBLAMMED!";
            BlamSound.Play();
            BlammedDisplay.SetActive(true);
            SubmitButton.SetActive(false);

            InfoDisplay.GetComponent<Text>().text = StoryText.Story3;
            string secondInfoText = StoryText.Story4;

            coroutine = SequenceAnimations("B", secondInfoText, (int)StoryText.EnableTypes.Submit);
            StartCoroutine(coroutine);

            SubmissionManager.BlammedSubmissions++;
        } else {
            if (SubmissionManager.SaveChance >= Random.Range(0.0f, 1.0f)) {
                StatusDisplay.GetComponent<Text>().text = "Your submission just got\nSAVED!";
                SaveSound.Play();
                SubmissionManager.SavedSubmissions++;
            } else {
                StatusDisplay.GetComponent<Text>().text = "Your submission just got\nBLAMMED!";
                BlamSound.Play();
                SubmissionManager.BlammedSubmissions++;
            }
        }

        if (SubmissionManager.SavedSubmissions == 1 && !SeenBHistory)
        {
            SavedDisplay.SetActive(true);
            ChanceDisplay.SetActive(true);

            InfoDisplay.GetComponent<Text>().text = StoryText.Story5;
            string secondInfoText = StoryText.Story6;

            coroutine = SequenceAnimations("B", secondInfoText, (int)StoryText.EnableTypes.Strawberry);
            StartCoroutine(coroutine);

            SeenBHistory = true;
        }
    }

    public IEnumerator SequenceAnimations(string submissionName, string infoText, int enableType)
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
            case (int)StoryText.EnableTypes.Apple:
                AppleButton.SetActive(true);
                break;
            case (int)StoryText.EnableTypes.Raspberry:
                RaspberryButton.SetActive(true);
                break;
            case (int)StoryText.EnableTypes.Pineapple:
                PineappleButton.SetActive(true);
                break;
        }

        SubmissionName.GetComponent<Text>().text = submissionName;
        InfoDisplay.GetComponent<Text>().text = infoText;
    }
}
