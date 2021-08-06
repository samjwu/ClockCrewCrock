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
}
