using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject enemyBlade;
    [SerializeField] private float torqueEnemy;

    [SerializeField] private float speedEnemy;

    public Transform _player;

    private Rigidbody enemyRb;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Vector3 offset = (_player.transform.position - transform.position).normalized;
        enemyRb.AddForce(offset * speedEnemy, ForceMode.Impulse);
        enemyRb.AddTorque(Vector3.up * torqueEnemy * Time.deltaTime, ForceMode.Impulse);

    }
}
