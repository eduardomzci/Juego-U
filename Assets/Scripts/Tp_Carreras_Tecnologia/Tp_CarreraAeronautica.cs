using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_CarreraAeronautica : MonoBehaviour
{
    public string cambioEscenaCarreras = "tecnologia";
    public int carrera;

    public void Awake()
    {
        LoadData();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt(cambioEscenaCarreras, carrera);
            SceneManager.LoadScene("TestFacultadTecnologia");
        }
    }

    //public void OnDestroy()
    //{
    //    SaveData();
    //}

    public void LoadData()
    {
        PlayerPrefs.DeleteKey(cambioEscenaCarreras);
    }

    //public void SaveData()
    //{
    //    PlayerPrefs.SetInt(cambioEscenaCarreras, carrera);
    //}
}
