using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaDemo : MonoBehaviour
{

    public float transitionTime = 3f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //LoadNextLevel();
            //SceneManager.LoadScene("Carrera1", LoadSceneMode.Single);
            //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Carrera1"));
            //SceneManager.LoadSceneAsync(1);
            StartCoroutine(EsperaParaEscena());
            //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Carrera1"));
            
        }
    }

    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(1));
    }

    IEnumerator EsperaParaEscena()
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(1);
        while (!ao.isDone)
        {
            yield return null;
        }
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
