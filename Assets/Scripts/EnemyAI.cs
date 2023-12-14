using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CanSeePlayer()){
            MoveTowardsPlayer();
        }
    }

    bool CanSeePlayer(){
        float distToPlayer = Vector3.Distance(transform.position, player.position);
        return distToPlayer < 10f;
    }

    void MoveTowardsPlayer(){
        Vector3 dir = (player.position - transform.position).normalized;
        transform.forward = dir;
        transform.position += dir*moveSpeed*Time.deltaTime; 
    }


}
