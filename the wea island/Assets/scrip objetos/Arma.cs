using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bala;
    public Transform spawnp;
    public float force;
    public int cartuchoMax = 16;
    private int cartuchoActual;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
            
        }
        if (Input.GetButtonDown("Correr"))
        {
            Recarga();
        }

    }
    void Shot()
    {
      GameObject go= Instantiate(bala, spawnp.position, spawnp.rotation);
            go.GetComponent<Rigidbody>().AddForce(go.transform.forward * force, ForceMode.Impulse);

        Destroy(go.gameObject, 3f);

        cartuchoActual--;
    }
    void Recarga()
    {
        cartuchoActual = cartuchoMax;
    }
}
