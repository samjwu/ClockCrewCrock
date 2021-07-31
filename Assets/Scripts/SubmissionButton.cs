using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmissionButton : MonoBehaviour
{
    public GameObject TitleDisplay;
    public GameObject StatusDisplay;
    public GameObject InfoText;

    public GameObject SavedDisplay;
    public GameObject BlammedDisplay;
    public GameObject ChanceDisplay;
    public GameObject SubmissionName;

    private IEnumerator coroutine;

    void Start()
    {
        this.gameObject.SetActive(true);

        InfoText.GetComponent<Text>().text = "First, there was nothing.\n\n\n" +
            "Then, there was Strawberry Clock.\n\n\n\n" +
            "Strawberry Clock is the true King of the Portal and God of Newgrounds.\n\n\n" +
            "That Tom Fulp guy is just a lackey who carries out his will.";
        Animation animation = InfoText.GetComponent<Animation>();

        coroutine = AnimationSequence(animation);
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
            //InfoText.SetActive(true);
            BlammedDisplay.SetActive(true);

            InfoText.GetComponent<Text>().text = "The foolish users of Newgrounds, not recognizing the genius of Strawberry Clock, BLAMMED 'A'.\n\n" + 
                "Thus a legendary masterpiece was lost to the annals of portal history, never to be seen again...";;
            InfoText.GetComponent<Animation>().Play("InfoTextAnimation");

            SubmissionName.GetComponent<Text>().text = "B";

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

        if (SubmissionManager.SavedSubmissions == 1)
        {
            SavedDisplay.SetActive(true);
            ChanceDisplay.SetActive(true);

            InfoText.GetComponent<Text>().text = "The second legendary submission was named 'B'. This time, the users listened.\n\n" +
            "Over 1 trillion users came into being to worship the newly crowned 'King of The Portal'. " +
            "Among these users were a group of clocks that formed the Clock Crew, a gathering of God-Kings and Supreme Beings...'";
            InfoText.GetComponent<Animation>().Play("InfoTextAnimation");
        }
    }

    IEnumerator AnimationSequence(Animation animation)
    {
        animation.Play("InfoTextAnimation");
        InfoText.GetComponent<Animation>().Play("InfoTextAnimation");

        while (animation.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }

        InfoText.GetComponent<Text>().text = "The first legendary submission by StrawberryClock was named 'A'.\n\n" +
            "It was glorious.\n\n\n" + 
            "Click it now!";
        animation.Play("InfoTextAnimation");
    }
}
