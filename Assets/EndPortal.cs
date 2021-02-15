using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPortal : MonoBehaviour
{
    public AudioSource gamemusic;

    IEnumerator EndRoutine()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
    void OnTriggerEnter(Collider other)
    {
        gamemusic.Stop();
        StartCoroutine(EndRoutine());
    }
}
