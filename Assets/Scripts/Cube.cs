using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Cube : MonoBehaviour
{
    [SerializeField] private int _directionMovement;
    [SerializeField] private Transform _target;

    private int _speed = 5;

    public Transform Target { get => _target; set => _target = value; }

    private void Update()
    {
        if (Target != null)
        {
            transform.LookAt(Target);
        }

        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    private void Awake()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
