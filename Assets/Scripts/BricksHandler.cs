using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksHandler : MonoBehaviour {

    [SerializeField] int countOfBricks; 
    [SerializeField] GameObject ball;

	public void IncreaseBrickCount()
    {
        Debug.Log("increasing to "+(countOfBricks+1).ToString());
        countOfBricks++;
    }

    public void DecreaseBrickCount()
    {
        Debug.Log("decreasing to " + (countOfBricks - 1).ToString());
        countOfBricks--;
        if(countOfBricks <= 0)
        {
            Debug.Log(ball.GetComponent<Rigidbody2D>());
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
