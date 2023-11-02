using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SkateboardMovement : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    private void Update()
    {
   
        // Перемещение скейтборда вперед/назад
        float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveForward);

        // Поворот скейтборда влево/вправо
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationY, 0f);
    }
}

