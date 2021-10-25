using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoPersonaje : MonoBehaviour
{
    public Animator anim;

    private Rigidbody rb;
    private NavMeshAgent agent;

    public RaycastHit hit;
    public Vector3 lugarfijo;
    public Vector3 lugarfijoParaParticulas;
    public Transform jugador;

    public GameObject particulasJugadorPocision;

    private bool bandera = false;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        //if (Input.GetMouseButton(0))
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                anim.SetBool("correr", true);
                anim.SetBool("quieto", false);
                lugarfijo = hit.point;
                agent.SetDestination(hit.point);
                //Iniciar Rutina Particulas marcando ubicacion a seguir por el jugador
                StartCoroutine(HabilitarDestruirParticulas());
            }
        }

        if (lugarfijo.x == jugador.transform.position.x && lugarfijo.z == jugador.transform.position.z)
        {
            anim.SetBool("correr", false);
            anim.SetBool("quieto", true);
        }
    }

    public IEnumerator HabilitarDestruirParticulas()
    {
        if (bandera==false)
        {
            lugarfijoParaParticulas = lugarfijo;
            lugarfijoParaParticulas.y += 0.5f;
            var cloneBomb = Instantiate(particulasJugadorPocision, lugarfijoParaParticulas, Quaternion.Euler(-90, 0, 0));
            yield return new WaitForSeconds(1f);
            Destroy(cloneBomb);
            //StartCoroutine(TiempoEntreRutina());
        }
    }

    //public IEnumerator TiempoEntreRutina()
    //{
    //    bandera = true;
    //    yield return new WaitForSeconds(1f);
    //    bandera = false;
    //}
}
