using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public void BeginGame()
    {
        SceneManager.LoadScene(2);
    }
}
