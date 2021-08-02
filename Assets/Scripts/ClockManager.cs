using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour
{
    public static int StrawberryCost = 1;
    public int currentSaved;
    public GameObject StrawberryButton;
    public GameObject StrawberryText;

    void Start()
    {
        
    }

    void Update()
    {
        currentSaved = SubmissionManager.SavedSubmissions;
        if (currentSaved >= StrawberryCost)
        {
            StrawberryButton.GetComponent<Button>().interactable = true;
        }
    }
}
