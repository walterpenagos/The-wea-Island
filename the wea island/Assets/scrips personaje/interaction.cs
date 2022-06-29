using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public estadisticas stat;
    public Transform camara;
    public Transform objeyoVacio;
    public Transform agarrarArma;
    public GameObject arma;
    public LayerMask lm;
    public GameObject cajagravedad;
    public float raydistance=5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "puerta" && stat.baterycont >= 4)
        {
            other.GetComponentInParent<puelta>().OnOpenDoor();
        }
        if (other.tag == "bateria")
        {
            other.GetComponentInParent<battery>().conchatumadre();
            stat.baterycont++;
        }
        if (other.tag == "arma")
        {
            arma.transform.parent = agarrarArma;
            arma.transform.localPosition = Vector3.zero;
            arma.transform.localRotation = Quaternion.identity;
            if (objeyoVacio.childCount>0)
            {
                other.gameObject.SetActive(false);
            }

        }
    }



    private void Update()
    {
        if (Input.GetButtonDown("Agarrar"))
        {
            if (objeyoVacio.childCount > 0)
            {
                objeyoVacio.GetComponentInChildren<Rigidbody>().isKinematic = false;
                objeyoVacio.DetachChildren();
                if (agarrarArma.childCount>0)
                    {
                        agarrarArma.GetChild(0).gameObject.SetActive(true);
                    }
            }
            else
            {
                
                Debug.DrawRay(camara.position, camara.transform.forward * 2, Color.black);



                if (Physics.Raycast(camara.position, camara.forward, out RaycastHit hit, raydistance, lm))
                {
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.parent = objeyoVacio;
                    hit.transform.localPosition = Vector3.zero;
                    hit.transform.localRotation = Quaternion.identity;

                    if (objeyoVacio.childCount>0)
                    {
                        agarrarArma.GetChild(0).gameObject.SetActive(false);
                    }
                }

                
               





            }


        }
    }
}
/*if (Input.GetButtonUp("Agarrar"))
                {
                    cajagravedad.GetComponent<Rigidbody>().isKinematic = false;
                    hit.transform.parent = null;
                }
                */
                /* if(Input.GetButtonDown("Soltar"))
                 {
                     hit.transform.parent = agarrarArma;
                     hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                     hit.transform.position = agarrarArma.position;
                 }*//* if (objeyoVacio.childCount>=0)
                {
                    arma.gameObject.SetActive(true);
                }
                if (objeyoVacio.childCount>0)
                {
                    arma.gameObject.SetActive(false);
                } */
 /* if (Input.GetButtonDown("Agarrar"))
                    {
                        cajagravedad.GetComponent<Rigidbody>().isKinematic = true;
                        Debug.Log(hit.transform.name);
                        hit.transform.parent = objeyoVacio;
                        hit.transform.localPosition = Vector3.zero;
                    }
                   */