using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShadowNavication : MonoBehaviour
{
    private Transform target;
    private GameObject Player;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("SD_unitychan_humanoid");
        target = Player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
