using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    [SerializeField] private float health;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DamageEnemy()
    {
        health -= 40;
        Debug.Log(gameObject.name + " health = " + health);
    }


}
