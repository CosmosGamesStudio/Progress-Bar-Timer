using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    public GameObject WinScreen;

    private void OnTriggerEnter(Collider other) {
        WinScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
