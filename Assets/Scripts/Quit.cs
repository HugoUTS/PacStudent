using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    [SerializeField] private string title = "StartScene";
    public void Title()
    {
        Debug.Log("Quit Button is working");
        SceneManager.LoadScene(title);
    }
}
