using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShadowNavication : MonoBehaviour
{
    private Transform target;
    private GameObject Player;
    public GameObject enemy;
    public bool target_number;

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("SD_unitychan_humanoid");
        target = Player.transform;
        agent = GetComponent<NavMeshAgent>();
        target_number = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        if (target_number == true)
        {
            target = enemy.transform;
        }
        else
        {
            target = Player.transform;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            target_number = true;
        }
        else
        {
            target_number = false;
        }
    }
}
