using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController Controller;

    public float speed = 10f;
    private float horInput;
    public float turnSpeed = 25f;

    void Update()
    {
        horInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horInput);

    }
}