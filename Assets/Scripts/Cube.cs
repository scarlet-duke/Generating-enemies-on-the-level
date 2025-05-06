using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Cube : MonoBehaviour
{
    [SerializeField] private int _directionMovement;
    private Transform _target;

    private int _speed = 5;

    private void Update()
    {
        if (_target != null)
        {
            transform.LookAt(_target);
        }

        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    private void Awake()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void Initialized(Transform target)
    {
        _target = target;
    }
}
