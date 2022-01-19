
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float yawSpeed = 10.0F;
    public float pitchSpeed = 10.0F;
    public Transform playerBody;
    public float xRotation;


    private void Awake()
    {
        playerBody.rotation = Quaternion.Euler(playerBody.rotation.eulerAngles.x, playerBody.rotation.eulerAngles.y, 0f);
    }
    private void Start()
    {
        playerBody.rotation = Quaternion.Euler(playerBody.rotation.eulerAngles.x, playerBody.rotation.eulerAngles.y, 0f);
        
    }
    Vector3 GetRotation()
    {
        float yaw = Input.GetAxis("Yaw") * yawSpeed * Time.deltaTime *-1;
        float pitch = Input.GetAxis("Pitch") * pitchSpeed * Time.deltaTime;
        xRotation -= yaw;
        xRotation = Mathf.Clamp(xRotation, -89f, 89f);
        playerBody.rotation = Quaternion.Euler(playerBody.rotation.eulerAngles.x, playerBody.rotation.eulerAngles.y, 0f);



        return new Vector2(yaw * yawSpeed, pitch * pitchSpeed);

    }

    void FixedUpdate()
    {
        playerBody.rotation = Quaternion.Euler(playerBody.rotation.eulerAngles.x, playerBody.rotation.eulerAngles.y, 0f);
        playerBody.Rotate(GetRotation());
        //transform.rotation = Quaternion.Euler(playerBody.localEulerAngles.z*-1, 0f, 0f);
        playerBody.rotation = Quaternion.Euler(playerBody.rotation.eulerAngles.x, playerBody.rotation.eulerAngles.y, 0f);


    }
    private void Update()
    {
        playerBody.rotation = Quaternion.Euler(playerBody.rotation.eulerAngles.x, playerBody.rotation.eulerAngles.y, 0f);

    }

}