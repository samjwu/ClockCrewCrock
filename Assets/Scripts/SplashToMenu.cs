using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadMenu());
    }

    void Update()
    {
        
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(20);
        SceneManager.LoadScene(1);
    }
}
