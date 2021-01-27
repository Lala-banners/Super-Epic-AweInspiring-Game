using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private float horizontalMove = 0f;
    public float speed = 40f;

    // Update is called once per frame
    void Update() //Input from player
    {
        //Test
        //print(Input.GetAxisRaw("Horizontal"));

        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void FixedUpdate() //Add input to character 
    {
        //Move player
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false); //Move in the right direction
    }
}
