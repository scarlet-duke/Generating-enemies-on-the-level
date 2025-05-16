using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Cube _prefab;
    [SerializeField] private Color _colorCube;
    [SerializeField] private TargetMover _targetSpawner;

    public void Spawn()
    {
        Cube spawnedCube = Instantiate(_prefab, transform.position, Quaternion.identity);
        spawnedCube.GetComponent<Renderer>().material.color = _colorCube;
        spawnedCube.Initialize(_targetSpawner);
    }
}
