using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour
{
    public static int StrawberryCost = 1;
    public int currentSaved;
    public GameObject StrawberryButton;
    public GameObject StrawberryCostText;
    public GameObject StrawberryText;

    void Start()
    {
        
    }

    void Update()
    {
        currentSaved = SubmissionManager.SavedSubmissions;
        StrawberryCostText.GetComponent<Text>().text = string.Format("Cost (Saves): {0:g}", StrawberryCost);

        if (currentSaved >= StrawberryCost) 
        {
            StrawberryButton.GetComponent<Button>().interactable = true;
        }
    }
}
