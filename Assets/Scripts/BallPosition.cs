using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPosition : MonoBehaviour {

    [SerializeField] GameObject paddle;
    [SerializeField] float forceX;
    [SerializeField] float forceY;

    private Vector2 paddleToBall;
    private bool hasStarted = false;

	// Use this for initialization
	void Start () {
        //var initialPosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        //transform.position = initialPosition;
        //Debug.Log(paddle.GetComponent<Collider2D>().bounds.size.);

        paddleToBall = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            var position = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
            transform.position = position + paddleToBall;
        }

        if(Input.GetMouseButtonDown(0) && !hasStarted)
        {
            if(hasStarted == false)
                hasStarted = true;

            GetComponent<Rigidbody2D>().velocity = new Vector2(forceX, forceY);
        }
	}
}
