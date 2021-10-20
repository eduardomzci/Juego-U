using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaTest : MonoBehaviour
{
    // Start is called before the first frame update
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
        StartCoroutine(LoadLevel(2));
    }

    IEnumerator LoadLevel(int numeroEscena)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(numeroEscena);
    }
}
