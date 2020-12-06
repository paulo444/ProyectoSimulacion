using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    public float movementSpeed =1;
    public float gravity = 9.8f;
    private float velocity = 0;
    private Camera cam;

    public Animator swordAnimator;
    public GameObject attack;
 
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        cam = Camera.main;
    }
 
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * movementSpeed;
        float vertical = Input.GetAxis("Vertical") * movementSpeed;
        characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);
 
        if(characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }

        if(Input.GetMouseButtonDown(0)){
            Attack();
        }
    }

    public void Attack(){
        swordAnimator.SetTrigger("Attack");
        attack.SetActive(true);

        StartCoroutine(AttackTime());
    }

    IEnumerator AttackTime(){
        yield return new WaitForSeconds(.30f);
        attack.SetActive(false);
    }
}
