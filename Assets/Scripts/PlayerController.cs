using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Animator animator;
    public RuntimeAnimatorController[] listAnimator;
    public int state;
    private bool attack;

	void Start () {
        animator = gameObject.GetComponent<Animator>();
        animator.runtimeAnimatorController = listAnimator[state];
        animator.SetBool("attack", attack);
	}
	
	void Update () {
	
	}
}
