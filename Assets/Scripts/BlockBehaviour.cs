using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

    [SerializeField] AudioClip audioClip;
    [SerializeField] GameObject level;

    private void Start()
    {
        level.GetComponent<Level>().IncreaseBricks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
        if(level.GetComponent<Level>().DecreaseBricks(collision.collider))
        {
            //all bricks are finished
            StartCoroutine(WaitBeforeSucessScreen(gameObject, 3f));
            gameObject.GetComponent<Renderer>().enabled = false;
            return;
        }

        Destroy(gameObject);
    }

    IEnumerator WaitBeforeSucessScreen(GameObject gameObject, float seconds)
    {
        //print(Time.time);
        yield return new WaitForSeconds(seconds);
        level.GetComponent<Level>().LoadStartScreen();
        Destroy(gameObject);
        //print(Time.time);
    }
}
