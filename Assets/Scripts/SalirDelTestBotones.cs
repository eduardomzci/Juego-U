using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirDelTestBotones : MonoBehaviour
{
    public void Salir()
    {
        SceneManager.LoadScene("MapaFacultadCienciasSalud");
    }

    public void Finalizar()
    {
        SceneManager.LoadScene("MapaFacultadCienciasSalud");
    }
}
