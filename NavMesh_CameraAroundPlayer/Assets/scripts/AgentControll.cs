using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControll : MonoBehaviour
{
    
    private NavMeshAgent navMeshAgent;
    [SerializeField] private float speed;
    [SerializeField] private LayerMask layer;



    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {       // Player running on mouse position click
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, layer))
        {
            if(Input.GetMouseButtonDown(0))
            {                                
                navMeshAgent.destination = hit.point;                         
            }                        
        }        
    }
}
