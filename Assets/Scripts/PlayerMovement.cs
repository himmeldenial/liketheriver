using UnityEngine;
using UnityEngine.InputSystem;

//gamecodelibrary
//im learning the code too i swear

public class PlayerMovement : MonoBehaviour
{
[SerializeField] private float moveSpeed = 5f;
//serializefield makes it so u can set the value of speed to whatever u want
//outside of coding i think? so in the unity engine itself
private Rigidbody2D rb;
private Vector2 moveInput;
private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    //gets the labelled components from whatever object this script is attached to
    //so in this case the player
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("isWalking", true);
    //sets the bool status to true whenever the player moves

    //context.canceled means something that gets set/happens once we've let go of whatever button we were pressing
    
        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX", moveInput.x);
            animator.SetFloat("LastInputY", moveInput.y);
        //since the player stopped, the last value of X will be the same before the player stopped moving
        //its important to put this code b4 the movement code so it wont be overwritten once it updates to 0
        //so last move x=3 -> lastInputX is set to 3 -> movement stops and value is set to 0 = not moving
        }

        moveInput = context.ReadValue<Vector2>();
        animator.SetFloat("InputX", moveInput.x);
        animator.SetFloat("InputY", moveInput.y);
    //sets the value of "InputX" in the animator as moveinput x-axis
    }
}
