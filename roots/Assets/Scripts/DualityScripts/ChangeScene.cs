using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject creditsCanvas;
    public GameObject mainCanvas;
    public AudioSource mainMenuMusic;
    public AudioSource creditsMusic;

    public void ChangeSceneByName(string name)
    {
        if (name == "start")
            StartCoroutine(StartGameCoroutine());
        else if (name == "credits")
            StartCoroutine(CreditsCoroutine());
        else if (name == "back")
            StartCoroutine(BackCoroutine());
    }

    IEnumerator StartGameCoroutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneName: "ShaneScene");
    }

    IEnumerator CreditsCoroutine()
    {
        yield return new WaitForSeconds(2);
        creditsCanvas.SetActive(true);
        mainCanvas.SetActive(false);
        mainMenuMusic.mute = true;
        creditsMusic.mute = false;
    }
    IEnumerator BackCoroutine()
    {
        yield return new WaitForSeconds(2);
        mainCanvas.SetActive(true);
        creditsCanvas.SetActive(false);
        mainMenuMusic.mute = false;
        creditsMusic.mute = true;
    }

}
