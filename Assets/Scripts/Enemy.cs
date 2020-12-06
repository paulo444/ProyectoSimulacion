using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent nav;
    public int health;
    private GameObject objectPlayer;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        objectPlayer = GameObject.Find("Player");
    }

    void Update()
    {
        nav.destination = objectPlayer.transform.position;
    }

    public void takeDamage(int d){
        health -= d;
    }
}
