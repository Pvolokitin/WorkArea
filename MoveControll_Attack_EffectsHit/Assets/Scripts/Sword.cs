using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public ParticleSystem hit;
    private PlayerControllerWASD onAttack;

    private void Start()
    {
        onAttack = GameObject.Find("Player").GetComponent<PlayerControllerWASD>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (onAttack.isAttack)
        {
            hit.Play();
        }
                      
    }
}
