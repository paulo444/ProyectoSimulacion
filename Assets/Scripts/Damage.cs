using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 10;
    public int normalDamage = 10;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Enemy"){
            col.gameObject.GetComponent<Enemy>().takeDamage(damage);
        }
    }

    public void doubleDamage(){
        damage = damage*2;
    }

    public void setDefaultDamage(){
        damage = normalDamage;
    }
}
