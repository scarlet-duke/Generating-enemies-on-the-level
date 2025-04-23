using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private int _directionMovement;

    private int _speed = 5;

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    private void Awake()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
