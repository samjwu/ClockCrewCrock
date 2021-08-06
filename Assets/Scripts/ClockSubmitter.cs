using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSubmitter : MonoBehaviour
{
    public static int StrawberrySubmitOutput;
    public int StrawberrySubmitting;
    public bool StrawberryCreating = false;

    public static int OrangeSubmitOutput;
    public int OrangeSubmitting;
    public bool OrangeCreating = false;

    public static int AppleSubmitOutput;
    public int AppleSubmitting;
    public bool AppleCreating = false;

    public static int RaspberrySubmitOutput;
    public int RaspberrySubmitting;
    public bool RaspberryCreating = false;

    public static int PineappleSubmitOutput;
    public int PineappleSubmitting;
    public bool PineappleCreating = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        StrawberrySubmitOutput = ClockManager.StrawberryPower;
        StrawberrySubmitting = StrawberrySubmitOutput;

        if (StrawberryCreating == false)
        {
            StrawberryCreating = true;
            StartCoroutine(StrawberryCreate());
        }

        OrangeSubmitOutput = ClockManager.OrangePower;
        OrangeSubmitting = OrangeSubmitOutput;

        if (OrangeCreating == false)
        {
            OrangeCreating = true;
            StartCoroutine(OrangeCreate());
        }

        AppleSubmitOutput = ClockManager.ApplePower;
        AppleSubmitting = AppleSubmitOutput;

        if (AppleCreating == false)
        {
            AppleCreating = true;
            StartCoroutine(AppleCreate());
        }

        RaspberrySubmitOutput = ClockManager.RaspberryPower;
        RaspberrySubmitting = RaspberrySubmitOutput;

        if (RaspberryCreating == false)
        {
            RaspberryCreating = true;
            StartCoroutine(RaspberryCreate());
        }

        PineappleSubmitOutput = ClockManager.PineapplePower;
        PineappleSubmitting = PineappleSubmitOutput;

        if (PineappleCreating == false)
        {
            PineappleCreating = true;
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

    IEnumerator AppleCreate()
    {
        SubmissionManager.SavedSubmissions += AppleSubmitting;
        yield return new WaitForSeconds(1f);
        AppleCreating = false;
    }

    IEnumerator RaspberryCreate()
    {
        SubmissionManager.SavedSubmissions += RaspberrySubmitting;
        yield return new WaitForSeconds(1f);
        RaspberryCreating = false;
    }

    IEnumerator PineappleCreate()
    {
        SubmissionManager.SavedSubmissions += PineappleSubmitting;
        yield return new WaitForSeconds(1f);
        PineappleCreating = false;
    }
}
