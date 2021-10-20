using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(CharacterController))]
public class MoveRaycast : MonoBehaviour
{
    public float InputX;
    public float InputZ;
    public float Speed;
    public float allowPlayerRotation = 0.1f;
    public CharacterController controller;
    public Animator anim;

    [Range(0, 1f)]
    public float StartAnimTime = 0.3f;
    [Range(0, 1f)]
    public float StopAnimTime = 0.15f;

    private Rigidbody rb;
    private NavMeshAgent agent;
    private LineRenderer line;
    private List<Vector3> point;
    public RaycastHit hit;
    public Vector3 lugarfijo;
    public Transform jugador;
    //public float aceleracion=0.2f;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        controller = this.GetComponent<CharacterController>();

        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        line = GetComponent<LineRenderer>();
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
                //agent.acceleration(aceleracion);
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
