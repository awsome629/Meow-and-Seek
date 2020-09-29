using UnityEngine;
using System.Collections;

public class bouncingBall : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("OnClick");
            //anim.SetBool("idle", true);
        }
    }
}