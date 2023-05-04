using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    IPushble _pushble;
    [SerializeField] Transform obj;
    [SerializeField] float maxSpeed;
    void Start()
    {
        _pushble = GetComponent<IPushble>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction;
        direction = (obj.position - transform.position).normalized;
        _pushble.Push(direction);
    }
}
