using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_Carrera_Salus : MonoBehaviour
{
    public string cambioEscenaCarreras = "salus";
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
            //SceneManager.LoadScene("TestFacultadCienciasSalud");
            c.enabled = false;
            StartCoroutine(ll.LoadLevel1("TestFacultadCienciasSalud"));
        }
    }

    public void LoadData()
    {
        PlayerPrefs.DeleteKey(cambioEscenaCarreras);
    }
}
