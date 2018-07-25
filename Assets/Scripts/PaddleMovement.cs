using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    [SerializeField] float screenWidth = 16f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.mousePosition.x / Screen.width * screenWidth);
        var currentLoc = Input.mousePosition.x / Screen.width * screenWidth;
        if (currentLoc > 0 && currentLoc < screenWidth)
        {
            Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
            paddlePos.x = Mathf.Clamp(currentLoc, 1f, 15f);
            transform.position = paddlePos;
        }

	}
}
