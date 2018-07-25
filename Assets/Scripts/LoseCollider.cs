using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScreenIndex + 1);
    }

}
