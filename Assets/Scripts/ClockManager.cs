using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour
{
    public static int StrawberryCost;
    public int currentSaved;
    public GameObject ClockButton;
    public GameObject ClockText;

    void Start()
    {
        
    }

    void Update()
    {
        currentSaved = SubmissionManager.SavedSubmissions;
        if (currentSaved >= 0)
        {
            ClockButton.GetComponent<Button>().interactable = true;
        }
    }
}
