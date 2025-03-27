using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    private GameObject patrol;
    private Enemy enemy;
    public float toleranceDistance = 0.1f;
    public List<Transform> waypoints;
    public int currentWaypointIndex;
    public Vector3 lastViewPlayer;

    private void OnEnable()
    {
        currentWaypointIndex = 0;
    }

    private void Start()
    {
        patrol = GameObject.Find("Patrol");
        waypoints = patrol.GetComponentsInChildren<Transform>().ToList();
        waypoints.RemoveAt(0);
        enemy = GetComponent<Enemy>();
    }
    
    public void StartPatrol()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < toleranceDistance)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Count)
            {
                currentWaypointIndex = 0;
            }
        }
        enemy.MoveToTarget(waypoints[currentWaypointIndex].position);
    }
}
