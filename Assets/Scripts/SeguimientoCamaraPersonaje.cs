using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamaraPersonaje : MonoBehaviour
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

        transform.position = new Vector3(posX -56f, transform.position.y, posZ + 127f);
    }
}
