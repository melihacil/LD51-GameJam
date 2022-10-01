using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{


    [SerializeField] private Transform playerPos;
    [SerializeField] private float distanceBetween;
    [SerializeField] private float speed;

    private bool enemyForward = true;
    private bool playerDirection = true;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = (playerPos.position.x - transform.position.x);
        EnemyDirection();
        EnemyTurn();
        if (Vector2.Distance(playerPos.position, transform.position) > distanceBetween)
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed);
    }

    private void EnemyDirection()
    {
        if (distance > 0)
        {
            playerDirection = true;
        }
        else if (distance < 0)
        {
            playerDirection=false;
        }


    }

    private void EnemyTurn()
    {
        if (playerDirection != enemyForward)
        {
            enemyForward = playerDirection;
            transform.forward *= -1;
        }
    }

}
