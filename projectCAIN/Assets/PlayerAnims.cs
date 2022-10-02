using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnims : MonoBehaviour
{

    public static PlayerAnims Instance { get; private set; }


    [SerializeField] private SpriteRenderer sword;
    [SerializeField] private Animator swordAnimator;


    private void Awake()
    {
        Instance = this;
        sword.enabled = false;
    }


    public void PlaySwordSwing()
    {
        sword.enabled = true;
        swordAnimator.SetTrigger("Swing");
        Invoke(nameof(DisableRenderer), 0.06f);
    }

    private void DisableRenderer()
    {
        sword.enabled = false;
    }


}
