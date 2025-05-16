using UnityEngine;

public class Cube : MonoBehaviour
{
    private TargetMover _target;

    private int _speed = 5;

    private void Update()
    {
        if (_target != null)
        {
            transform.LookAt(_target.transform);
        }

        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    public void Initialize(TargetMover target)
    {
        _target = target;
    }
}