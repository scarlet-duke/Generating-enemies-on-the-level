using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Cube _prefab;
    [SerializeField] private Color _colorCube;

    public void Spawn()
    {
        int fullSpin = 360;
        int directionMovement = Random.Range(0, fullSpin + 1);
        GameObject spawnedCube = Instantiate(_prefab.gameObject, transform.position, Quaternion.Euler(0, directionMovement, 0));
        spawnedCube.GetComponent<Renderer>().material.color = _colorCube;
    }
}
