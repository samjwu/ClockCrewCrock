using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSubmitter : MonoBehaviour
{
    public static int StrawberrySubmitOutput = 1;
    public int StrawberrySubmitting;
    public bool StrawberryCreating = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        StrawberrySubmitting = StrawberrySubmitOutput;

        if (StrawberryCreating == false)
        {
            StrawberryCreating = true;
            StartCoroutine(StrawberryCreate());
        }
    }

    IEnumerator StrawberryCreate()
    {
        SubmissionManager.SavedSubmissions += StrawberrySubmitting;
        yield return new WaitForSeconds(1f);
        StrawberryCreating = false;
    }
}
