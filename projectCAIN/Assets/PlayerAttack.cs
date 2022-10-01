using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField]
    private Transform attackPos;
    [SerializeField]
    private float attackRadius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           //Attacking all the enemies in the radius
            Collider2D[] col = Physics2D.OverlapCircleAll(attackPos.position, attackRadius, LayerMask.GetMask("Enemy"));
            if (col != null)
            {
                foreach (Collider2D col2 in col)
                {
                    Debug.Log("Hit enemy = " + col2.gameObject.name);
                }
            }
            
        }
    }
}