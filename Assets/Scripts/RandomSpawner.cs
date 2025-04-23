using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private List<Spawner> enemyList;

    private float _timeInterval = 2f;

    private void Start()
    {
        InvokeRepeating("Spawner—all", _timeInterval, _timeInterval);
    }

    private void Spawner—all()
    {
        int call = Random.Range(0, enemyList.Count);
        enemyList[call].Spawn();
    }
}
