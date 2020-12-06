using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent nav;
    public int health;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        GameObject objectPlayer = GameObject.Find("Player");
        nav.destination = objectPlayer.transform.position;
    }

    public void takeDamage(int d){
        health -= d;
    }
}
