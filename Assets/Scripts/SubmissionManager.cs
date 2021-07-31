using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmissionManager : MonoBehaviour
{
    public static int SentSubmissions;
    public int SubmissionCount;
    public GameObject TitleDisplay;
    public GameObject SubmissionButton;
    public GameObject StatusDisplay;
    public GameObject InfoText;

    public static float SaveChance;
    public GameObject ChanceDisplay;

    public static int SavedSubmissions;
    public int SavedCount;
    public GameObject SavedDisplay;

    public static int BlammedSubmissions;
    public int BlammedCount;
    public GameObject BlammedDisplay;

    void Start()
    {
        TitleDisplay.SetActive(false);
        SubmissionButton.SetActive(false);
        StatusDisplay.SetActive(false);
        //InfoText.SetActive(false);

        SavedDisplay.SetActive(false);
        BlammedDisplay.SetActive(false);
        ChanceDisplay.SetActive(false);
}

    void Update()
    {
        SubmissionCount = SentSubmissions;

        SavedCount = SavedSubmissions;
        SavedDisplay.GetComponent<Text>().text = string.Format("Saved Submissions: {0:g}", SavedCount);

        BlammedCount = BlammedSubmissions;
        BlammedDisplay.GetComponent<Text>().text = string.Format("Blammed Submissions: {0:g}", BlammedCount);

        SaveChance = Math.Min(0.5f + (float) SavedCount / 10000f, 1f);
        ChanceDisplay.GetComponent<Text>().text = string.Format("Save Chance: {0:n}%", SaveChance*100);
    }
}
