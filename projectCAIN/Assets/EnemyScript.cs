using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{


    [SerializeField] private Transform playerPos;
    [SerializeField] private float distanceBetween;
    [SerializeField] private float speed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(playerPos.position, transform.position) > distanceBetween)
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed);
    }
}
