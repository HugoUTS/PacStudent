using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    // Update is called once per frame
    public void Title()
    {
        SceneManager.LoadScene("StartScene");
        Application.Quit();
        Debug.Log("MENU");
    }
}
