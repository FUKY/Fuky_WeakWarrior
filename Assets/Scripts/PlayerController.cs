using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Animator animator;
    public RuntimeAnimatorController[] listAnimator;
    public int state;
	void Start () {
        animator = gameObject.GetComponent<Animator>();
        animator.runtimeAnimatorController = listAnimator[state];
	}
	
	void Update () {
	
	}
}
