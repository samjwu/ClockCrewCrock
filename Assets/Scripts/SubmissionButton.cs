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
    public GameObject BlammedDisplay;
    public GameObject ChanceDisplay;

    public GameObject InfoDisplay;
    private const float InfoAnimationLength = 7f;

    private IEnumerator coroutine;

    void Start()
    {
        InfoDisplay.GetComponent<Text>().text = "First, there was nothing.\n\n\n" +
            "Then, there was StrawberryClock.\n\n\n" +
            "StrawberryClock is the true King of the Portal and God of Newgrounds.\n\n\n" +
            "That Tom Fulp guy is just a lackey who carries out his will.";
        string secondInfoText = "The first legendary submission by StrawberryClock was named 'A'.\n\n" +
            "It was glorious.\n\n\n" +
            "Click it now!";

        coroutine = SequenceAnimations(InfoDisplay.GetComponent<Animation>(), "A", secondInfoText);
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
            BlammedDisplay.SetActive(true);
            SubmitButton.SetActive(false);

            InfoDisplay.GetComponent<Text>().text = "The foolish users of Newgrounds, not recognizing the genius of StrawberryClock, BLAMMED 'A'.\n\n" +
                    "Thus a legendary masterpiece was lost to the annals of portal history, never to be seen again...";
            string secondInfoText = "However, Strawberry Clock knew the portal needed its King.\n\n" + 
                "Consequently, he produced a SECOND legendary submission by the name of 'B'.\n\n" + 
                "This too was glorious.\n\n\n" + 
                "Keep clicking it until something happens!";

            coroutine = SequenceAnimations(InfoDisplay.GetComponent<Animation>(), "B", secondInfoText);
            StartCoroutine(coroutine);

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

        if (SubmissionManager.SavedSubmissions == 1 && !SeenBHistory)
        {
            SavedDisplay.SetActive(true);
            ChanceDisplay.SetActive(true);

            InfoDisplay.GetComponent<Text>().text = "This time, the users listened. The legendary 'B' was saved.\n\n" +
            "Trillions of users began to worship the King of The Portal.\n\n" +
            "Among these users were a group of clocks that formed the Clock Crew, a gathering of God-Kings and Supreme Beings...";
            string secondInfoText = "Holy clock! Is that who I think it is?\n\n" +
                "It 'B' StrawberryClock himself! The leader of the Clock Crew!\n\n\n" +
                "Quickly, click on him now!";

            coroutine = SequenceAnimations(InfoDisplay.GetComponent<Animation>(), "B", secondInfoText);
            StartCoroutine(coroutine);

            SeenBHistory = true;
        }
    }

    IEnumerator SequenceAnimations(Animation animation, string submissionName, string infoText)
    {
        animation.Rewind("InfoTextAnimation");
        animation.Play("InfoTextAnimation");
        while (animation.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }

        SubmitButton.SetActive(true);
        SubmissionName.GetComponent<Text>().text = submissionName;
        InfoDisplay.GetComponent<Text>().text = infoText;
        animation.Play("InfoTextAnimation");
    }
}
