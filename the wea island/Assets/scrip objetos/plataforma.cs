using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public GameObject paltaforma;
    
    public Transform minpos;
    public Transform maxpos;
    public float speedass=5;

    private void OnTriggerStay(Collider other)
    {
        if (other!=null)
        {
            Moveplataforma();
        }
    }

    private void Moveplataforma()
    {
        paltaforma.transform.Translate(Vector3.up * Time.deltaTime * speedass);
        if (paltaforma.transform.position.y>=maxpos.position.y)
        {
            speedass = -5f;
        }
        if (paltaforma.transform.position.y <= minpos.position.y)
        {
            speedass = 5;
        }
    
    }

}
