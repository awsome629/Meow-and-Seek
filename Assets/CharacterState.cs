using UnityEngine;
using System.Collections;

public class CharacterState : MonoBehaviour
{
    private Animator animator;
    float speed;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (transform.hasChanged)
        {
            animator.SetTrigger("IsWalking");
            transform.hasChanged = false;
        }
        else
            animator.SetTrigger("IsIdle");
    }
}