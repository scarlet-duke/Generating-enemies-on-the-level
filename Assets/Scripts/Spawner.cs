using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int _directionMovement = 0;
    [SerializeField] private Color _colorCube;

    public void Spawn()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = transform.position;
        cube.transform.rotation = Quaternion.Euler(0, _directionMovement, 0);
        cube.AddComponent<Rigidbody>();
        cube.AddComponent<Cube>();
        cube.GetComponent<Renderer>().material.color = _colorCube;
    }
}
