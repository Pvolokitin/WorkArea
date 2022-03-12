using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerWASD : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 10f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody playerRb;
    private Animator playerAnim;

    

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 offset = new Vector3(h, 0, v);
        playerRb.AddForce(offset * playerSpeed, ForceMode.Force);
        if(offset.magnitude > Mathf.Abs(0.05f))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(offset), Time.deltaTime * rotationSpeed);
        }
        
        AnimtationWalking(v, h);
        AnimationAttack();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerAnim.SetBool("isRunning", true);
            playerSpeed = 100f;
        }
        else
        {
            playerAnim.SetBool("isRunning", false);
            playerSpeed = 50f;
        }

        Debug.Log("Скорость персонажа = " + playerSpeed);
    }




    // walking
    void AnimtationWalking(float v, float h)
    {
        //walk
        if (h != 0 || v != 0) playerAnim.SetFloat("speed", 1);
        else playerAnim.SetFloat("speed", 0);        
    }   

    // attack
    void AnimationAttack()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            playerAnim.SetBool("IsAttack", true);
        }
        else
        {
            playerAnim.SetBool("IsAttack", false);

        }
    }
}

