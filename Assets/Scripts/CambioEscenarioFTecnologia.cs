using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class CambioEscenarioFTecnologia : MonoBehaviour
{
    public GameObject HabilitarObject;
    public GameObject Personaje;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene("MapaFacultadCienciasSalud");
            HabilitarObject.SetActive(true);
            MovimientoPersonaje mp = other.gameObject.GetComponent<MovimientoPersonaje>();
            Vector3 st = other.gameObject.transform.position;
            NavMeshAgent ag = Personaje.gameObject.GetComponent<NavMeshAgent>();
            ag.SetDestination(st);
            mp.anim.SetBool("correr", false);
            mp.anim.SetBool("quieto", true);
            mp.enabled = false;
        }
    }

    public void CambiarescenarioMapaFacultadTecnologia()
    {
        SceneManager.LoadScene("MapaFacultadTecnologia");
    }
    public void SalirCanvas()
    {
        HabilitarObject.SetActive(false);
        Personaje.GetComponent<MovimientoPersonaje>().enabled = true;
    }
}
