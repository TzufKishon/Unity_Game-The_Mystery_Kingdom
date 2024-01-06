using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepScript : MonoBehaviour
{
    public GameObject footstep;
    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) //walking
            footsteps();

        if (Input.GetKey(KeyCode.X)) //StopWalking
            stopFootsteps();
    }

   void footsteps()
   {
        footstep.SetActive(true);
   }

    void stopFootsteps()
    {
        footstep.SetActive(false);
    }
}
