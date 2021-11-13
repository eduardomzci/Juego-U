using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    private string nombreEscena = "";
    
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel1(nombreEscena));
    }

    public IEnumerator LoadLevel1(string nombrees)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(nombrees);
    }
}
