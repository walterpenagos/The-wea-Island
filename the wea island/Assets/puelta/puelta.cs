using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puelta : MonoBehaviour
{
    public Animator anim;
    public void OnOpenDoor()
    {
        anim.SetTrigger("opendoor");
    }
}
