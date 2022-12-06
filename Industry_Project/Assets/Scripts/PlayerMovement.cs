using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public AudioSource footstep;

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButton("Vertical"))
        {
            if (!footstep.isPlaying)
            {
                footstep.Play();
            }
        }

        if (!Input.GetButton("Vertical") & !Input.GetButton("Horizontal"))
        {
            if (footstep.isPlaying)
            {
                footstep.Stop();
            }
        }

        if (Input.GetButton("Horizontal"))
        {
            if (!footstep.isPlaying)
            {
                footstep.Play();
            }
        }

        if (!Input.GetButton("Horizontal") & !Input.GetButton("Vertical"))
        {
            if (footstep.isPlaying)
            {
                footstep.Stop();
            }
        }
    }
}
