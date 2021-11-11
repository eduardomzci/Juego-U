using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_Carrera_Salus : MonoBehaviour
{
    public string cambioEscenaCarreras = "salus";
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
            SceneManager.LoadScene("TestFacultadCienciasSalud");
        }
    }

    public void LoadData()
    {
        PlayerPrefs.DeleteKey(cambioEscenaCarreras);
    }
}
