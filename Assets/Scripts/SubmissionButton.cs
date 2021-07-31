using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmissionButton : MonoBehaviour
{
    public GameObject TitleDisplay;
    public GameObject StatusDisplay;
    public GameObject SavedDisplay;
    public GameObject BlammedDisplay;
    public GameObject ChanceDisplay;
    public GameObject SubmissionName;
    public GameObject InfoText;

    bool _isPlayingHistory = false;

    public void CreatedSubmission()
    {
        if (SubmissionName.GetComponent<Text>().text == "A")
        {
            TitleDisplay.SetActive(true);
            StatusDisplay.SetActive(true);
            StatusDisplay.GetComponent<Text>().text = "Your submission just got\nBLAMMED!";
            SavedDisplay.SetActive(true);
            BlammedDisplay.SetActive(true);
            ChanceDisplay.SetActive(true);

            InfoText.GetComponent<Text>().text = "The first legendary submission 'A' by StrawberryClock AKA 'King of The Portal' was BLAMMED.\n" + 
                "Thus it was lost to the annals of portal history, never to be seen again...";
            InfoText.GetComponent<Animation>().Play("InfoTextAnimation");

            SubmissionName.GetComponent<Text>().text = "B";
            PlayBHistory(10f); // TODO fix this

            SubmissionManager.BlammedSubmissions++;
        } else {
            if (SubmissionManager.SaveChance >= Random.Range(0.0f, 1.0f)) {
                StatusDisplay.GetComponent<Text>().text = "Your submission just got\nSAVED!";
            
                SubmissionManager.SavedSubmissions++;
            } else {
                StatusDisplay.GetComponent<Text>().text = "Your submission just got\nBLAMMED!";
                
                SubmissionManager.BlammedSubmissions++;
            }
        }
    }

    IEnumerator PlayBHistory(float time)
    {
        if (_isPlayingHistory)
        {
            yield break;
        }

        _isPlayingHistory = false;
        yield return new WaitForSeconds(time);

        InfoText.GetComponent<Text>().text = "The second legendary submission was named 'B' and started a huge following (about 1 trillion) " +
            "of worshippers for the newly crowned 'King of The Portal'. " +
            "Among these followers were the 'Apostles' who were a group of clocks that formed the Clock Crew, a gathering of Kings and Supreme Beings...'";
        InfoText.GetComponent<Animation>().Play("InfoTextAnimation");

        _isPlayingHistory = false;
    }
}
