using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public ParticleSystem hit;    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("walls"))
        {
            hit.Play();
        }
    }
}
