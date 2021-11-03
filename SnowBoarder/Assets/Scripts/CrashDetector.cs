using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] CircleCollider2D HeadCollider;
    [SerializeField] float reloadWait = 1f;
    [SerializeField] ParticleSystem crashEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == HeadCollider)
        {
            crashEffect.Play();
            Invoke("ReloadScene", reloadWait);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
