using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public CharacterController2D controller;
    public float runspeed = 40f;
    public float HorizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    HorizontalMove = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * HorizontalMove * Time.deltaTime * runspeed);

    HorizontalMove = Input.GetAxis("Vertical");
    transform.Translate(Vector3.up * HorizontalMove * Time.deltaTime * runspeed);
    }

    /*void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
    }*/
    
}
