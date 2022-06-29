using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : MonoBehaviour
{
    public AudioSource wea;
    public AudioClip weasonora;
    public float volumen = 1;

    public void conchatumadre()
    {
        gameObject.SetActive(false);

        wea.transform.position = transform.position;

        wea.PlayOneShot(weasonora, volumen);
    }

}
