using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(controlmovimiento))]

public class enemicontrol : MonoBehaviour
{
    public controlmovimiento moviminetoEnemico;
    public Transform jugador;
    public float rangoDetect=7f;
    
    
   
    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, jugador.position);
        if (distancia<=rangoDetect)
        {
            if (Vector2.Dot((transform.position - jugador.position).normalized,transform.TransformDirection(Vector3.forward).normalized)<0.95f)
            {
                if ((Vector2.Dot((transform.position - jugador.position).normalized, transform.TransformDirection(Vector3.right).normalized)>0))
                {
                    moviminetoEnemico.RotarPersonaje(-5f);
                }
                else
                {
                    moviminetoEnemico.RotarPersonaje(5f);
                }
            }
            
           // moviminetoEnemico.Move(1, 0);
        }
        
    }
}
