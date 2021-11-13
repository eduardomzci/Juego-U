using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AditivoTransicion : MonoBehaviour
{
    public void Awake()
    {
        StartCoroutine(empezar());
    }
    public IEnumerator empezar()
    {
        this.GetComponent<Canvas>().enabled = false;
        yield return new WaitForSeconds(1f);
        this.GetComponent<Canvas>().enabled = true;
    }
}
