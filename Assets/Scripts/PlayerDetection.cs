using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public GameObject teleport;
    public Damage damage;
    public GameObject goldenSword;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Teleport"){
            string name = col.gameObject.GetComponent<Teleport>().getTeleportName();
            teleport.GetComponent<SceneController>().LoadLevel(name);
        }else if(col.gameObject.tag == "Item"){
            StartCoroutine(activateGoldenSword());
            Destroy(col.gameObject);
        }
    }

    IEnumerator activateGoldenSword(){
        damage.doubleDamage();
        goldenSword.GetComponent<MeshRenderer>().material.color = Color.yellow;
        yield return new WaitForSeconds(15);
        damage.setDefaultDamage();
        goldenSword.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
