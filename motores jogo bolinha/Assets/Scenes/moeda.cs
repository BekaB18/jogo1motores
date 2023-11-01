using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour
{
    public int velocidadeGiro = 150;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtrairMoedas(1);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
    }

}
