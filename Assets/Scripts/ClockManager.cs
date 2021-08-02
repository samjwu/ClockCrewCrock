using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour
{
    public int currentSaved;

    public static int StrawberryCost = 1;
    public static int StrawberryPower = 1;
    public GameObject StrawberryButton;
    public GameObject StrawberryCostText;
    public GameObject StrawberryText;
    public GameObject StrawberryPowerText;

    public static int TotalPower = 1;

    void Start()
    {
        
    }

    void Update()
    {
        currentSaved = SubmissionManager.SavedSubmissions;
        StrawberryCostText.GetComponent<Text>().text = string.Format("Cost (Saves): {0:g}", StrawberryCost);
        StrawberryPowerText.GetComponent<Text>().text = string.Format("Output (Submissions/Sec): {0:g}", StrawberryPower);

        if (currentSaved >= StrawberryCost) 
        {
            StrawberryButton.GetComponent<Button>().interactable = true;
        } else
        {
            StrawberryButton.GetComponent<Button>().interactable = false;
        }
    }
}
