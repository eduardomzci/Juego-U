using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamaraPersonaje_MapaFacultadTecnologia : MonoBehaviour
{
    public float AdicionEjeX = 0f;
    public float AdicionEjeZ = 0f;
    public GameObject follow;
    void Start()
    {

    }

    void Update()
    {
        float posX = follow.transform.position.x;
        float posZ = follow.transform.position.z;

        transform.position = new Vector3(posX + AdicionEjeX, transform.position.y, posZ + AdicionEjeZ);
    }
}
