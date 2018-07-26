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
        Destroy(gameObject);
        level.GetComponent<Level>().DecreaseBricks(collision.collider);
    }
}
