using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 3;
    public Image[] hearts;
    public GameObject gameOver;

    public void takeDamage(){
        health--;
        setHearts();

        if(health <= 0){
            gameOver.GetComponent<SceneController>().LoadLevel("Finish");
        }
    }

    public void setHearts(){
        for(int i=0; i<hearts.Length; i++){
            if(health >= i+1){
                hearts[i].gameObject.SetActive(true);
            }else{
                hearts[i].gameObject.SetActive(false);
            }
        }
    }
}
