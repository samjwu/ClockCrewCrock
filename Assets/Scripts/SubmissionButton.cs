using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmissionButton : MonoBehaviour
{
    public GameObject TitleDisplay;
    public GameObject SavedDisplay;
    public GameObject BlammedDisplay;
    public GameObject ChanceDisplay;
    public GameObject SubmissionName;

    public void CreatedSubmission()
    {
        TitleDisplay.SetActive(true);
        SavedDisplay.SetActive(true);
        BlammedDisplay.SetActive(true);
        ChanceDisplay.SetActive(true);

        if (SubmissionName.GetComponent<Text>().text == "A") {
            SubmissionManager.BlammedSubmissions++;
            SubmissionName.GetComponent<Text>().text = "B";
        } else {
            if (SubmissionManager.SaveChance >= Random.Range(0.0f, 1.0f)) {
                SubmissionManager.SavedSubmissions++;
            } else {
                SubmissionManager.BlammedSubmissions++;
            }
        }
    }
}
