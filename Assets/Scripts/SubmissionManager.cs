using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmissionManager : MonoBehaviour
{
    public GameObject TitleDisplay;
    public GameObject StatusDisplay;

    public static int SavedSubmissions;
    public GameObject SavedDisplay;
    public int SavedCount;

    public static int BlammedSubmissions;
    public GameObject BlammedDisplay;
    public int BlammedCount;

    public static float SaveChance;
    public GameObject ChanceDisplay;

    void Start()
    {
        TitleDisplay.SetActive(false);
        StatusDisplay.SetActive(false);
        SavedDisplay.SetActive(false);
        BlammedDisplay.SetActive(false);
        ChanceDisplay.SetActive(false);
    }

    void Update()
    {
        SavedCount = SavedSubmissions;
        SavedDisplay.GetComponent<Text>().text = string.Format("Saved Submissions: {0:g}", SavedCount);

        BlammedCount = BlammedSubmissions;
        BlammedDisplay.GetComponent<Text>().text = string.Format("Blammed Submissions: {0:g}", BlammedCount);

        SaveChance = Math.Min(0.5f + (float) SavedCount / 10000f, 1f);
        ChanceDisplay.GetComponent<Text>().text = string.Format("Save Chance: {0:n}%", SaveChance*100);
    }
}
