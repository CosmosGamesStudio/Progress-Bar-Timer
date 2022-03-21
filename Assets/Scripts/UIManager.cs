using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject LoseScreen;

    void Start()
    {
        LoseScreen.SetActive(false);
    }

    void Update()
    {
        if(CountDownTimer.realTime < 0)
            LoseScreen.SetActive(true);
    }


    public static void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

