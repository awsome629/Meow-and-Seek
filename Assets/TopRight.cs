using UnityEngine;
using System.Collections;

public class TopRight : MonoBehaviour
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
            anim.SetTrigger("Open");
            //anim.SetBool("idle", true);
        }
		
		if (Input.GetMouseButtonUp(0))
		{
			anim.SetTrigger("Closed");
		}
    }
}