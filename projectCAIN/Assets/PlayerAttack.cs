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
           //RaycastHit2D hit =  Physics2D.Raycast(transform.position, attackPos.position, 4f, LayerMask.GetMask("Enemy"));
            Collider2D[] col = Physics2D.OverlapCircleAll(attackPos.position, attackRadius, LayerMask.GetMask("Enemy"));
            if (col != null)
            {
                foreach(Collider2D col2 in col)
                    Debug.Log("Hit enemy = " + col2.gameObject.name);
                /*
                 * 
                 * foreach(Collider2D hit in col)
                 */
            }
            //Debug.DrawRay(transform.position, attackPos.position, Color.red, 4.0f);
            
        }
        



    }
}
