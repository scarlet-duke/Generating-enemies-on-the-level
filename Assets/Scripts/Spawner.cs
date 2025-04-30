using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Cube _prefab;
    [SerializeField] private Color _colorCube;
    [SerializeField] private Transform _targetSpawner;

    public void Spawn()
    {
        GameObject spawnedCube = Instantiate(_prefab.gameObject, transform.position, Quaternion.Euler(0, 0, 0));
        spawnedCube.GetComponent<Renderer>().material.color = _colorCube;
        spawnedCube.GetComponent<Cube>()._target = _targetSpawner;
    }
}
