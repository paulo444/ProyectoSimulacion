using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public GameObject teleport;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Teleport"){
            string name = col.gameObject.GetComponent<Teleport>().getTeleportName();
            teleport.GetComponent<SceneController>().LoadLevel(name);
        }
    }
}
