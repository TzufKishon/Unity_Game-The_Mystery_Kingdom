using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Mutantmotion : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) //walking
        {
            // Check if the agent is properly placed on the NavMesh before setting destination
            if (agent.isOnNavMesh)
            {
                animator.SetInteger("State", 1);
                agent.SetDestination(target.transform.position);
            }
        }
        if (Input.GetKey(KeyCode.X)) //StopWalking
        {
            animator.SetInteger("State", 0);
            agent.SetDestination(agent.transform.position);
        }
        if (Input.GetKey(KeyCode.C)) //sitting
            animator.SetInteger("State", 2);
        if (Input.GetKey(KeyCode.V)) //Standing
            StartCoroutine(Standing());
    }
    IEnumerator Standing()
    {
        animator.SetInteger("State", 3);
        yield return new WaitForSeconds(2);
        animator.SetInteger("State", 0); //Breathing
    }
}
