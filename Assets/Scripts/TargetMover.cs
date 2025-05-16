using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed = 10.0f;   

    private int _currentWaypointIndex = 0;
    private float _triggerDistance = 0.1f;

    private void Update()
    {
        if (_waypoints.Length == 0) 
            return;

        Vector3 target = _waypoints[_currentWaypointIndex].position;
        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);

        if ((transform.position - target).sqrMagnitude < (_triggerDistance * _triggerDistance))
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
        }
    }
}
