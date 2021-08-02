using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSubmitter : MonoBehaviour
{
    public static int SubmissionIncrease = 1;
    public int SubmissionIncreaseCount;
    public bool CreatingSubmission = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        SubmissionIncreaseCount = SubmissionIncrease;

        if (CreatingSubmission == false)
        {
            CreatingSubmission = true;
            StartCoroutine(CreateSubmission());
        }
    }

    IEnumerator CreateSubmission()
    {
        SubmissionManager.SavedSubmissions += SubmissionIncreaseCount;
        yield return new WaitForSeconds(1f);
        CreatingSubmission = false;
    }
}
