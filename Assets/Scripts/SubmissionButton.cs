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

    public GameObject InfoDisplay;
    private const float InfoAnimationLength = 7f;

    private IEnumerator coroutine;

    enum EnableTypes
    {
        Submit = 0,
        Strawberry = 1,
        Orange = 2,
        Apple = 3,
        Raspberry = 4,
        Pineapple = 5
    }

    void Start()
    {
        InfoDisplay.GetComponent<Text>().text = "First, there was nothing.\n" +
            "Then, there was StrawberryClock.\n" +
            "StrawberryClock is the true King of the Portal and God of Newgrounds.\n" +
            "That Tom Fulp guy is just a lackey who carries out his will.";
        string secondInfoText = "The first legendary submission by StrawberryClock was named 'A'.\n" +
            "It was glorious.\n" +
            "Click it now!";

        coroutine = SequenceAnimations(InfoDisplay.GetComponent<Animation>(), "A", secondInfoText, (int) EnableTypes.Submit);
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

            InfoDisplay.GetComponent<Text>().text = "The foolish users of Newgrounds, not recognizing the genius of StrawberryClock, BLAMMED 'A'.\n" +
                    "Thus a legendary masterpiece was lost to the annals of portal history, never to be seen again...";
            string secondInfoText = "However, StrawberryClock knew the portal needed its King.\n" + 
                "Consequently, he produced a SECOND legendary submission by the name of 'B'.\n" + 
                "This too was glorious.\n" + 
                "Keep clicking it until something happens!";

            coroutine = SequenceAnimations(InfoDisplay.GetComponent<Animation>(), "B", secondInfoText, (int) EnableTypes.Submit);
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

            InfoDisplay.GetComponent<Text>().text = "This time, the users listened. The legendary 'B' was saved.\n" +
            "Trillions of users began to worship the King of The Portal.\n" +
            "Among these users were a group of clocks that formed the Clock Crew, a gathering of God-Kings and Supreme Beings...";
            string secondInfoText = "Holy clock! Is that who I think it is?\n" +
                "It 'B' StrawberryClock himself! The leader of the Clock Crew!\n" +
                "Quickly, click on him now!";

            coroutine = SequenceAnimations(InfoDisplay.GetComponent<Animation>(), "B", secondInfoText, (int) EnableTypes.Strawberry);
            StartCoroutine(coroutine);

            SeenBHistory = true;
        }
    }

    IEnumerator SequenceAnimations(Animation animation, string submissionName, string infoText, int enableType)
    {
        //animation.Rewind("InfoTextAnimation");
        //animation.Play("InfoTextAnimation");
        //while (animation.isPlaying)
        //{
        //    yield return new WaitForEndOfFrame();
        //}
        yield return new WaitForSeconds(5);

        switch (enableType)
        {
            case (int) EnableTypes.Submit:
                SubmitButton.SetActive(true);
                break;
            case (int) EnableTypes.Strawberry:
                StrawberryButton.SetActive(true);
                break;
            case (int)EnableTypes.Orange:
                OrangeButton.SetActive(true);
                break;
        }

        SubmissionName.GetComponent<Text>().text = submissionName;
        InfoDisplay.GetComponent<Text>().text = infoText;
        //animation.Play("InfoTextAnimation");
    }
}
