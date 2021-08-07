using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour
{
    public int currentSaved;

    public static int StrawberryCost = 1;
    public static int StrawberryPower = 0;
    public GameObject StrawberryButton;
    public GameObject StrawberryCostText;
    public GameObject StrawberryPowerText;

    public static int OrangeCost = 2;
    public static int OrangePower = 0;
    public GameObject OrangeButton;
    public GameObject OrangeCostText;
    public GameObject OrangePowerText;

    public static int RaspberryCost = 4;
    public static int RaspberryPower = 0;
    public GameObject RaspberryButton;
    public GameObject RaspberryCostText;
    public GameObject RaspberryPowerText;

    public static int AppleCost = 8;
    public static int ApplePower = 0;
    public GameObject AppleButton;
    public GameObject AppleCostText;
    public GameObject ApplePowerText;

    public static int PineappleCost = 16;
    public static int PineapplePower = 0;
    public GameObject PineappleButton;
    public GameObject PineappleCostText;
    public GameObject PineapplePowerText;

    public static int LevelThreshold = 3;
    public static int StrawberryLevel = 0;
    public static int OrangeLevel = 0;
    public static int AppleLevel = 0;
    public static int RaspberryLevel = 0;
    public static int PineappleLevel = 0;
    public static int TotalPower = 1;

    void Update()
    {
        currentSaved = SubmissionManager.SavedSubmissions;
        
        StrawberryCostText.GetComponent<Text>().text = string.Format("Cost (Saves): {0:g}", StrawberryCost);
        StrawberryPowerText.GetComponent<Text>().text = string.Format("Output (Saves/Sec): {0:g}", StrawberryPower);

        if (currentSaved >= StrawberryCost) 
        {
            StrawberryButton.GetComponent<Button>().interactable = true;
        } else
        {
            StrawberryButton.GetComponent<Button>().interactable = false;
        }

        OrangeCostText.GetComponent<Text>().text = string.Format("Cost (Saves): {0:g}", OrangeCost);
        OrangePowerText.GetComponent<Text>().text = string.Format("Output (Saves/Sec): {0:g}", OrangePower);

        if (currentSaved >= OrangeCost)
        {
            OrangeButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            OrangeButton.GetComponent<Button>().interactable = false;
        }

        RaspberryCostText.GetComponent<Text>().text = string.Format("Cost (Saves): {0:g}", RaspberryCost);
        RaspberryPowerText.GetComponent<Text>().text = string.Format("Output (Saves/Sec): {0:g}", RaspberryPower);

        if (currentSaved >= RaspberryCost)
        {
            RaspberryButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            RaspberryButton.GetComponent<Button>().interactable = false;
        }

        AppleCostText.GetComponent<Text>().text = string.Format("Cost (Saves): {0:g}", AppleCost);
        ApplePowerText.GetComponent<Text>().text = string.Format("Output (Saves/Sec): {0:g}", ApplePower);

        if (currentSaved >= AppleCost)
        {
            AppleButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            AppleButton.GetComponent<Button>().interactable = false;
        }

        PineappleCostText.GetComponent<Text>().text = string.Format("Cost (Saves): {0:g}", PineappleCost);
        PineapplePowerText.GetComponent<Text>().text = string.Format("Output (Saves/Sec): {0:g}", PineapplePower);

        if (currentSaved >= PineappleCost)
        {
            PineappleButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            PineappleButton.GetComponent<Button>().interactable = false;
        }
    }
}
