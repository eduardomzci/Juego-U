using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamaraPersonajeMapaFCienciasSalud : MonoBehaviour
{
    public Vector3 offset;
    public GameObject follow;
    void Start()
    {

    }

    void Update()
    {
        float posX = follow.transform.position.x;
        float posZ = follow.transform.position.z;

        if (posZ + 3f < 10)
        {
            transform.position = new Vector3(posX, transform.position.y, posZ + 3f);
        }
        else
        {
            transform.position = new Vector3(posX, transform.position.y, 10f);
        }
    }
}
