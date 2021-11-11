using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaDemo : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene("Carrera1");
        }
    }

    public void mapaPrincipal() 
    {
        SceneManager.LoadScene(0);
    } 
}
