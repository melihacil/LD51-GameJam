using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float force;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rb.AddForce(transform.right * force, ForceMode2D.Impulse);
    }


    //Will do the attack in here
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)//LayerMask.GetMask("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyStats>().DamageEnemy();
            Debug.Log("Attacking enemy");
            Destroy(gameObject);
        }
    }
}
