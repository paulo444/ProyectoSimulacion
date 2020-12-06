using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent nav;
    private TextMesh txt;
    public int health;
    private GameObject objectPlayer;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        txt = GetComponent<TextMesh>();
        txt.text = "Vida: " + health.ToString();
        objectPlayer = GameObject.Find("Player");
    }

    void Update()
    {
        nav.destination = objectPlayer.transform.position;
    } 

    public void takeDamage(int d){
        health -= d;
        txt.text = "Vida: " + health.ToString();

        if(health <= 0){
            Destroy(this.gameObject);
        }
    }
}
