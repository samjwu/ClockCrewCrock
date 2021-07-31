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
            "Then, there was Strawberry Clock.\n\n\n" +
            "Strawberry Clock is the true King of the Portal and God of Newgrounds.\n\n\n" +
            "That Tom Fulp guy is just a lackey who carries out his will.";

        coroutine = PlayAHistory(InfoDisplay.GetComponent<Animation>());
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

            InfoDisplay.GetComponent<Text>().text = "The foolish users of Newgrounds, not recognizing the genius of Strawberry Clock, BLAMMED 'A'.\n\n" + 
                "Thus a legendary masterpiece was lost to the annals of portal history, never to be seen again...";;
            InfoDisplay.GetComponent<Animation>().Play("InfoTextAnimation");

            SubmitButton.SetActive(false);

            coroutine = ReplaceAWithB(InfoAnimationLength);
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

            InfoDisplay.GetComponent<Text>().text = "The second legendary submission was named 'B'. This time, the users listened.\n\n" +
            "Over 1 trillion users came into being to worship the newly crowned 'King of The Portal'.\n\n" +
            "Among these users were a group of clocks that formed the Clock Crew, a gathering of God-Kings and Supreme Beings...'";
            InfoDisplay.GetComponent<Animation>().Play("InfoTextAnimation");
            SeenBHistory = true;
        }
    }

    IEnumerator PlayAHistory(Animation animation)
    {
        animation.Play("InfoTextAnimation");
        while (animation.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }

        SubmitButton.SetActive(true);
        InfoDisplay.GetComponent<Text>().text = "The first legendary submission by StrawberryClock was named 'A'.\n\n" +
            "It was glorious.\n\n\n" + 
            "Click it now!";
        animation.Play("InfoTextAnimation");
    }

    IEnumerator ReplaceAWithB(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        SubmitButton.SetActive(true);
        SubmissionName.GetComponent<Text>().text = "B";
    }
}
