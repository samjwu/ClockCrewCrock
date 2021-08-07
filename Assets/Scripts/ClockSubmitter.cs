using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSubmitter : MonoBehaviour
{
    public static int StrawberrySubmitOutput;
    public int StrawberrySubmitting;
    public static bool StrawberryCreating = false;

    public static int OrangeSubmitOutput;
    public int OrangeSubmitting;
    public static bool OrangeCreating = false;

    public static int RaspberrySubmitOutput;
    public int RaspberrySubmitting;
    public static bool RaspberryCreating = false;

    public static int AppleSubmitOutput;
    public int AppleSubmitting;
    public static bool AppleCreating = false;

    public static int PineappleSubmitOutput;
    public int PineappleSubmitting;
    public static bool PineappleCreating = false;
    
    void Update()
    {
        StrawberrySubmitOutput = ClockManager.StrawberryPower;
        StrawberrySubmitting = StrawberrySubmitOutput;

        if (StrawberryCreating == true)
        {
            StartCoroutine(StrawberryCreate());
        }

        OrangeSubmitOutput = ClockManager.OrangePower;
        OrangeSubmitting = OrangeSubmitOutput;

        if (OrangeCreating == true)
        {
            StartCoroutine(OrangeCreate());
        }

        RaspberrySubmitOutput = ClockManager.RaspberryPower;
        RaspberrySubmitting = RaspberrySubmitOutput;

        if (RaspberryCreating == true)
        {
            StartCoroutine(RaspberryCreate());
        }

        AppleSubmitOutput = ClockManager.ApplePower;
        AppleSubmitting = AppleSubmitOutput;

        if (AppleCreating == true)
        {
            StartCoroutine(AppleCreate());
        }

        PineappleSubmitOutput = ClockManager.PineapplePower;
        PineappleSubmitting = PineappleSubmitOutput;

        if (PineappleCreating == true)
        {
            StartCoroutine(PineappleCreate());
        }
    }

    IEnumerator StrawberryCreate()
    {
        SubmissionManager.SavedSubmissions += StrawberrySubmitting;
        yield return new WaitForSeconds(1f);
        StrawberryCreating = false;
    }

    IEnumerator OrangeCreate()
    {
        SubmissionManager.SavedSubmissions += OrangeSubmitting;
        yield return new WaitForSeconds(1f);
        OrangeCreating = false;
    }

    IEnumerator RaspberryCreate()
    {
        SubmissionManager.SavedSubmissions += RaspberrySubmitting;
        yield return new WaitForSeconds(1f);
        RaspberryCreating = false;
    }

    IEnumerator AppleCreate()
    {
        SubmissionManager.SavedSubmissions += AppleSubmitting;
        yield return new WaitForSeconds(1f);
        AppleCreating = false;
    }

    IEnumerator PineappleCreate()
    {
        SubmissionManager.SavedSubmissions += PineappleSubmitting;
        yield return new WaitForSeconds(1f);
        PineappleCreating = false;
    }
}
