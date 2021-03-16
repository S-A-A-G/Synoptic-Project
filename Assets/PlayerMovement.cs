using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //calls for the seperate character controller
    public CharacterController2D controller;

    //allows the script to access the animator to switch animations
    public Animator animator;

    //a variable to set the speed of the character
    public float runSpeed = 40f;

    //a variable with a default value to allow communication betweenUpdate and FixedUpdate
    float horizontalMovement = 0f;

    //a variable that will be used to determine the vertical position of the player
    float verticalPos = 0f;

    //a boolean to update whether the player has jumped or not
    bool jump = false;


    // Update is called once per frame
    void Update()
    {
        //sets the movement and speed of the sprite when an input is detected
        horizontalMovement = Input.GetAxisRaw("Horizontal") * runSpeed;

        //this gets the vertical position of the player
        verticalPos = transform.position.y;

        //checks to see if the player is moving in order to start the running animation
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));

        //checks to see if the Jump key (spacebar) has been pressed
        //then sets the jump boolean to true in order to make the sprite jump
        //animator.SetBool is checking to see if the player has jumped to start the jumping animation
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        // this loop determines that if the player is above a certain height (0.1)
        //then it will set the animator parameter "Grounded" to false
        if (verticalPos > -4.2)
        {
            animator.SetBool("Grounded", false);
        }
    }

    //checks to see if the player has landed to stop the jumping animation
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("Grounded", true);
    } 

    //a seperate method for updating physics which updates independantly of refresh rate
    void FixedUpdate ()
    {
        //move the player
        //Time.fixedDeltaTime = time passed since the last time FixedUpdate was called 
        //and ensures we move the same amount no matter how often FixedUpdate is called
        //
        //the jump=false line is to set it so that once the sprite has jumped, as stated in the 
        //controller.Move function, it stops jumping so that it doesnt jump indefinitely
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
