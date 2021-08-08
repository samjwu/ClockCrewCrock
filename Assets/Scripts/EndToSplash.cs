using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndToSplash : MonoBehaviour
{
    public GameObject AgainButton;

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
