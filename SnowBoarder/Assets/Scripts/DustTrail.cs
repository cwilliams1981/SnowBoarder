using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] CapsuleCollider2D boardCollider;
    [SerializeField] ParticleSystem snowEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == boardCollider)
        {
            snowEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider == boardCollider)
        {
            snowEffect.Stop();
        }
    }

}
