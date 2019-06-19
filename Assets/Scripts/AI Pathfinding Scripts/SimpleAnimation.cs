using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimation : MonoBehaviour {

    bool isWalkingInParent;
    private Animator mAnimator;

	// Use this for initialization
	void Start () {
      
        mAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        isWalkingInParent = this.transform.parent.GetComponent<TacticsMove>().moving;
        mAnimator.SetBool("isWalking", isWalkingInParent);
	}
}
