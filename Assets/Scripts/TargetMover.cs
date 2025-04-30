using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 10.0f;   
    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;
        {
            Vector3 target = waypoints[currentWaypointIndex].position;
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, target) < 0.01f)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
        }
    }
}
