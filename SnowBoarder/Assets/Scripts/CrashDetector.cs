using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] CircleCollider2D HeadCollider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == HeadCollider)
        {
            SceneManager.LoadScene(0);
        }
    }

}
