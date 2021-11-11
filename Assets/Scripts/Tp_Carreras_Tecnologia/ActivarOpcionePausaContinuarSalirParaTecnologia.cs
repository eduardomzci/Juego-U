using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ActivarOpcionePausaContinuarSalirParaTecnologia : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject CanvasOpciones;
    public void ActivarOpcionMenuPausa()
    {
        MenuPausa.SetActive(true);
        CanvasOpciones.SetActive(false);
    }

    public void ActivarOpcionContinuar()
    {
        MenuPausa.SetActive(false);
        CanvasOpciones.SetActive(true);
    }

    public void ActivarOpcionSalir()
    {
        SceneManager.LoadScene("MapaFacultadTecnologia");
    }
}
