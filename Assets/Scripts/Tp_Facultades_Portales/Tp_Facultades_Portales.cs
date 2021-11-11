using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_Facultades_Portales : MonoBehaviour
{
    public string NombreDeEscenaPortal;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(NombreDeEscenaPortal);
        }
    }
}
