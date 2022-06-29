using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    public AudioSource emitir;
    public AudioClip []weasonora;


    private void PlaySFX(int index, Vector3 desidereposition) 
    {
        transform.position = desidereposition;
        emitir.PlayOneShot(weasonora[index]);
    
    }
}
