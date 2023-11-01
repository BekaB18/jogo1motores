using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offset;
    void Start()
    {
        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        offset = alvo.position - transform.position;
    }

    
    void Update()
    {
        transform.position = alvo.position - offset;
    }
}
