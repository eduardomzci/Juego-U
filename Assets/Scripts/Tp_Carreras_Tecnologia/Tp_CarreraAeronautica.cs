using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_CarreraAeronautica : MonoBehaviour
{
    public string cambioEscenaCarreras = "tecnologia";
    public int carrera;
    public LoadLevel ll;
    public Canvas c;

    public void Awake()
    {
        LoadData();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt(cambioEscenaCarreras, carrera);
            //SceneManager.LoadScene("TestFacultadTecnologia");
            c.enabled = false;
            StartCoroutine(ll.LoadLevel1("TestFacultadTecnologia"));
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
