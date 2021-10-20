using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaDemo : MonoBehaviour
{

    public float transitionTime = 1f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LoadNextLevel();
            //SceneManager.LoadScene(1);
        }
    }

    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(1));
    }

    IEnumerator LoadLevel(int numeroEscena)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(numeroEscena);
    }

    public void mapaPrincipal() 
    {
        SceneManager.LoadScene(0);
    } 
}
