using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_CarreraAeronautica : MonoBehaviour
{
    private string cambioEscenaCarreras = "tecnologia";
    public int carrera;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("TestFacultadTecnologia");
        }
    }

    public void OnDestroy()
    {
        SaveData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt(cambioEscenaCarreras, carrera);
    }
}
