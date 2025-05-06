using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private List<Spawner> enemyList;

    private float _timeInterval = 2f;

    private void Start()
    {
        StartCoroutine(Spawner—all(_timeInterval));
    }

    private IEnumerator Spawner—all(float intervalSeconds)
    {
        while (enabled)
        {
            int call = Random.Range(0, enemyList.Count);
            enemyList[call].Spawn();
            yield return new WaitForSeconds(intervalSeconds);
        }
    }
}
