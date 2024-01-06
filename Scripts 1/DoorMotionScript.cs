using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotionScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
        animator.SetBool("DoorIsOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
        animator.SetBool("DoorIsOpening", false);
    }
}
