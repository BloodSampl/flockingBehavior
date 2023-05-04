using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetPuller : MonoBehaviour
{
    IPushble _pushble;
    // Start is called before the first frame update
    void Start()
    {
       _pushble = GetComponent<IPushble>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 gravity = Vector3.zero - transform.position;
        _pushble.Push(gravity);
    }
}
