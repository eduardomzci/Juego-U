using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_Carrera_Gastronomia : MonoBehaviour
{
    public string cambioEscenaCarreras = "gastronomia";
    public int carrera;

    public Canvas c;
    public LoadLevel ll;

    public void Awake()
    {
        LoadData();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt(cambioEscenaCarreras, carrera);
            //SceneManager.LoadScene("TestFacultadArquitectura");
            c.enabled = false;
            StartCoroutine(ll.LoadLevel1("TestFacultadArquitectura"));
        }
    }

    public void LoadData()
    {
        PlayerPrefs.DeleteKey(cambioEscenaCarreras);
    }
}
