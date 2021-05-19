using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZFix : MonoBehaviour
{
    void Awake()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 50);        
    }

    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 50);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 50);
    }
}
