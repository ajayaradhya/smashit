using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

    [SerializeField] AudioClip audioClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
        Destroy(gameObject);
    }
}
