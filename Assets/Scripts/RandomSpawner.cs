using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private List<Spawner> _enemyList;

    private float _timeInterval = 2f;
    private WaitForSeconds _wait;

    private void Start()
    {
        _wait = new WaitForSeconds(_timeInterval);
        StartCoroutine(SpawnerCall(_wait));
    }

    private IEnumerator SpawnerCall(WaitForSeconds intervalSeconds)
    {
        while (enabled)
        {
            int call = Random.Range(0, _enemyList.Count);
            _enemyList[call].Spawn();
            yield return intervalSeconds;
        }
    }
}
