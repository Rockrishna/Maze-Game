using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Setting an instance of player controls
    PlayerControlls controls;

    //Setting up variables
    public CharacterController controller;
    public float speed = 12f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 3f;
    public float limit = 22f;

    void jumpy()
    {
        if (isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
    void runnyp()
    {
        if (limit == 22f && speed < 22f)
        {
            speed = 22f;
        }
        else if (limit == 40f  && speed < 22f)
        {
            speed = 40f;
        }
    }
    void runnyc()
    {
        if (limit == 22f && speed > 12f)
        {
            
            speed = 12f;
        }
        else
        {
            speed = 40f;
        }
    }
    void Cheate()
    {
        controls.Gameplay.Cheat2.performed += ctx => Cheater();
    }
    void Cheater()
    {
        speed = 40;
        limit = 40;
    }
    void Pause ()
    {
        SceneManager.LoadScene("StartMenu");
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
    //Awake is called before start
    private void Awake()
    {
        controls = new PlayerControlls();
        controls.Gameplay.Jump.performed += ctx => jumpy();
        controls.Gameplay.RunK.performed += ctx => runnyp();
        controls.Gameplay.RunK.canceled += ctx => runnyc();
        controls.Gameplay.RunC.performed += ctx => runnyp();
        controls.Gameplay.Cheat1.performed += ctx => Cheate();
        controls.Gameplay.PauseK.performed += ctx => Pause();
        controls.Gameplay.PauseT.performed += ctx => Pause();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if ((Input.GetKeyDown("v"))&&(Input.GetKeyDown("s")))
        {
            limit = 40f;
        }
        //getting infromation from the controller
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetJoystickNames().Length != 0 && x == 0 && z == 0)
        {
            speed = 12f;
        }
        
        //moving the character
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
