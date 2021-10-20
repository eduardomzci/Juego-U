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
    public Transform jugador;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                anim.SetBool("correr", true);
                anim.SetBool("quieto", false);
                lugarfijo = hit.point;
                agent.SetDestination(hit.point);
            }
        }

        if (lugarfijo.x == jugador.transform.position.x && lugarfijo.z == jugador.transform.position.z)
        {
            anim.SetBool("correr", false);
            anim.SetBool("quieto", true);
        }
    }
}
