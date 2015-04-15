using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
    public float speed = 3f;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	void Update () {
        rb2d.velocity = new UnityEngine.Vector2(speed, rb2d.velocity.y);
	}
}
