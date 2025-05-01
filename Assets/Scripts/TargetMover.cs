using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed = 10.0f;   
    private int _currentWaypointIndex = 0;

    private void Update()
    {
        if (_waypoints.Length == 0) return;
        {
            Vector3 target = _waypoints[_currentWaypointIndex].position;
            transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);

            if ((transform.position - target).sqrMagnitude < 0.01f)
            {
                _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
            }
        }
    }
}
