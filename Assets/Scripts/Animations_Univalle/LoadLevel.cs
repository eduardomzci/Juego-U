using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string nombreescena;
    
    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel1(nombreescena));
    }

    public IEnumerator LoadLevel1(string escenaes)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(escenaes);
    }
}
