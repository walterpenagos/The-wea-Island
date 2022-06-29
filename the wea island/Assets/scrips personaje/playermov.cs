using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(controlmovimiento))]

public class playermov : MonoBehaviour
{
    controlmovimiento playerMovement;
    Vector2 direccionpersonaje;


    [Header("movimiento camara y rotacion personaje")]
    public Camera camara;
    Vector2 rotacionCyP;
    float posicionCamaraY;


    private void Start()
    {
        playerMovement = GetComponent<controlmovimiento>();
    }

    private void Update()
    {

        direccionpersonaje = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rotacionCyP = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        if (Input.GetButton("Correr"))
        {

            playerMovement.Run();
        }
        playerMovement.Move(direccionpersonaje.x, direccionpersonaje.y);
        playerMovement.RotarPersonaje(rotacionCyP.x);
        RotarCamara(rotacionCyP.y);
        if (Input.GetButtonDown("Jump"))
        {
            playerMovement.Saltar();
        }

    }

    public void RotarCamara(float rotaCamera)
    {
        posicionCamaraY += rotaCamera;
        posicionCamaraY = Mathf.Clamp(posicionCamaraY, -90, 90);
        camara.transform.localRotation = Quaternion.Euler(-posicionCamaraY, 0, 0);
    }
}

