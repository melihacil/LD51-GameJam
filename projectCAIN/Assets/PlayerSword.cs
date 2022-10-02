using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSword : MonoBehaviour
{

    [SerializeField] private Transform attackPos;
    [SerializeField] private float range;

    Vector3 mousePosition;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //difference.Normalize();
        difference.x = difference.x - attackPos.position.x;
        difference.y = difference.y - attackPos.position.y;
        difference.Normalize();
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
        

    }
}
