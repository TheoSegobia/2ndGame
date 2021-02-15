using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public AudioSource clickSound;
    public GameObject inputs;
    public GameObject menu;
    public AudioSource MenuMusicSound;
    
    public void NewGame()
    {
        MenuMusicSound.Stop();
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        clickSound.Play();
        Application.Quit();
    }

    public void Inputs()
    {
        clickSound.Play();
        menu.SetActive(false);
        inputs.SetActive(true);
    }

    public void Back()
    {
        clickSound.Play();
        menu.SetActive(true);
        inputs.SetActive(false);
    }

}
