using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    //[SerializeField] GameObject ball;
    [SerializeField] AudioClip backgroundAudio;
    [SerializeField] AudioClip onSuccessAudio;

    public static GameObject levelObject;
    private AudioSource audioSource;

    private int bricksCount;

    private void Start()
    {
        bricksCount = 0;
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null)
        {
            audioSource.clip = backgroundAudio;
            audioSource.Play();
        }

        levelObject = gameObject;
    }

    public void LoadNextScreen()
    {
        var currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScreenIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadSuccessScreen()
    {
        SceneManager.LoadScene("SuccessScreen");
    }


    public void IncreaseBricks()
    {
        bricksCount++;
        Debug.Log("+ " + bricksCount);
    }

    public bool DecreaseBricks(Collider2D collider)
    {
        bricksCount--;
        Debug.Log("- " + bricksCount);
        if (bricksCount <= 0)
        {
            var rigidBody = collider.GetComponent<Rigidbody2D>();
            var currentVelocity = rigidBody.velocity;
            rigidBody.velocity = new Vector2(currentVelocity.x / 50, currentVelocity.y / 50);
            rigidBody.angularDrag = 0;
            rigidBody.mass = 0;
            rigidBody.gravityScale = 0;

            //Debug.Log(levelObject);
            audioSource = levelObject.GetComponent<AudioSource>();
            audioSource.Stop();
            audioSource.clip = onSuccessAudio;
            audioSource.Play();

            ////StartCoroutine(WaitBeforeSucessScreen(4));
            return true;
        }
        return false;
    }

    IEnumerator WaitBeforeSucessScreen(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
