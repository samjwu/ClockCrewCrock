using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmissionManager : MonoBehaviour
{
    // click count
    public static int SentSubmissions;
    public int SubmissionCount;

    public GameObject TitleDisplay;
    public GameObject SubmitButton;
    public GameObject StatusDisplay;

    public static float SaveChance;
    public GameObject ChanceDisplay;

    public static int SavedSubmissions;
    public int SavedCount;
    public GameObject SavedDisplay;

    public static int BlammedSubmissions;
    public int BlammedCount;
    public GameObject BlammedDisplay;

    public GameObject StrawberryButton;
    public GameObject OrangeButton;
    public GameObject RaspberryButton;
    public GameObject AppleButton;
    public GameObject PineappleButton;

    void Start()
    {
        TitleDisplay.SetActive(false);
        SubmitButton.SetActive(false);
        StatusDisplay.SetActive(false);

        SavedDisplay.SetActive(false);
        BlammedDisplay.SetActive(false);
        ChanceDisplay.SetActive(false);

        StrawberryButton.SetActive(false);
        OrangeButton.SetActive(false);
        RaspberryButton.SetActive(false);
        AppleButton.SetActive(false);
        PineappleButton.SetActive(false);
    }

    void Update()
    {
        SubmissionCount = SentSubmissions;

        SaveChance = Math.Min(0.5f + (float) SavedCount / 10000f, 1f);
        ChanceDisplay.GetComponent<Text>().text = string.Format("Save Chance: {0:n}%", SaveChance*100);

        SavedCount = SavedSubmissions;
        SavedDisplay.GetComponent<Text>().text = string.Format("Saved Submissions: {0:g}", SavedCount);

        BlammedCount = BlammedSubmissions;
        BlammedDisplay.GetComponent<Text>().text = string.Format("Blammed Submissions: {0:g}", BlammedCount);
    }
}
