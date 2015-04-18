using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Animator animator;
    public RuntimeAnimatorController[] listAnimator;
    public int state;
    private bool facingRight = true;
    
    private Transform frontCheck;

	void Start () {
        animator = gameObject.GetComponent<Animator>();
        animator.runtimeAnimatorController = listAnimator[state];
        animator.SetBool("attack", false);
        frontCheck = transform.Find("frontCheck").transform;
	}

    public void FlipRight()
    {
        Vector3 theScale = transform.localScale;
        theScale.x = 1;
        transform.localScale = theScale;
        animator.SetBool("attack", true);
    }

    public void FlipLeft()
    {
        Vector3 theScale = transform.localScale;
        theScale.x = -1;
        transform.localScale = theScale;
        animator.SetBool("attack", true);
    }       
    public void IdleState()
    {
        // Chuyển về trạng thái Idle sau khi Attack xong
        animator.SetBool("attack", false);
    }

    void FixedUpdate()
    {
        Collider2D[] frontEnemy = Physics2D.OverlapPointAll(frontCheck.position);
        foreach (Collider2D c in frontEnemy)
        {
            // Player chém trúng Enemy
            if (c.tag == "Enemy" && animator.GetBool("attack") == true)
            {
                Debug.Log("enemyDeath");
            }
        }
    }

}
