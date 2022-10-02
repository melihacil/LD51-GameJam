using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField]
    private Transform attackPos;

    [SerializeField] 
    GameObject sword;

    [SerializeField]
    private float attackRadius;

    private PlayerAnims anim;






    // Start is called before the first frame update
    void Start()
    {
        anim = PlayerAnims.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           //Attacking all the enemies in the radius
            //Collider2D[] col = Physics2D.OverlapCircleAll(attackPos.position, attackRadius, LayerMask.GetMask("Enemy"));
            Instantiate(sword, attackPos.position, attackPos.rotation);

            
        }
    }
}
