using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent Mob;

    public GameObject Player;

    public float MobDistanceRun;

    private CharacterController characterController;

    [Range(0, 100)] public float walkRadius;
    [Range(1, 5)] public float speed;

    private void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
        if(Mob != null)
        {
            Mob.speed = speed;
            Mob.SetDestination(RandomNavMeshLocation());
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        // Run towards player

        if (distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            Mob.SetDestination(newPos);
            Mob.speed = 5;
        }
        else if (Mob != null && Mob.remainingDistance <= Mob.stoppingDistance)
        {
            Mob.speed = speed;
            Mob.SetDestination(RandomNavMeshLocation());
        }
    
    }
    public Vector3 RandomNavMeshLocation()
    {
        Vector3 finalPos = Vector3.zero;
        Vector3 randomPos = Random.insideUnitSphere * walkRadius;
        randomPos += transform.position;
        if (NavMesh.SamplePosition(randomPos, out NavMeshHit hit, walkRadius, 1))
        {
            finalPos = hit.position;
        }
        return finalPos;
    }
}
