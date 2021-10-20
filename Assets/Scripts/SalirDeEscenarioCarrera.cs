using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirDeEscenarioCarrera : MonoBehaviour
{
    public float transitionTime = 1f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(0));
    }

    IEnumerator LoadLevel(int numeroEscena)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(numeroEscena);
    }
}
