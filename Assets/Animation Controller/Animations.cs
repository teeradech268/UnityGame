using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

  Animator animator;
  int isWalkingHash;
  int isRunningHash;
  int isBackingHash;
  int isRunBackHash;

  void Start()
  {
    animator = GetComponent<Animator>();
    isWalkingHash = Animator.StringToHash("isWalking");
    isRunningHash = Animator.StringToHash("isRunning");
    isBackingHash = Animator.StringToHash("isBacking");
    isRunBackHash = Animator.StringToHash("isRunBacking");

  }

  void Update()
  {
    bool isRunning = animator.GetBool(isRunningHash);
    bool isWalking = animator.GetBool(isWalkingHash);
    bool isbacking = animator.GetBool(isBackingHash);
    bool isRunBacking = animator.GetBool(isRunBackHash);

    bool forward = Input.GetKey("w");
    bool back = Input.GetKey("s");
    bool runPressed = Input.GetKey("left shift");
    bool Jump = Input.GetKeyDown(KeyCode.Space);

    //Walk
    if(!isWalking && forward)
    {
      animator.SetBool(isWalkingHash,true);
    }
    if(isWalking && !forward)
    {
      animator.SetBool(isWalkingHash,false);
    }

    //Running
    if(!isRunning && (runPressed && forward))
    {
      animator.SetBool(isRunningHash,true);
    }
    if(isRunning && (!runPressed || !forward))
    {
      animator.SetBool(isRunningHash,false);
    }

    //Backing
    if(!isbacking && back)
    {
      animator.SetBool(isBackingHash,true);
    }
    if(isbacking && !back)
    {
      animator.SetBool(isBackingHash,false);
    }

    //RunningBack
    if(!isRunBacking && (runPressed && back))
    {
      animator.SetBool(isRunBackHash,true);
    }
    if(isRunBacking && (!runPressed || !back))
    {
      animator.SetBool(isRunBackHash,false);
    }

    //Jumping
    if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("Jumping");
        }
  }
    // Start is called before the first frame update
}
