using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;



public class SkateboardMovement : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;
    public int coins;
    public GameObject losePanel;
    public TextMeshProUGUI coinsText;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
   
        // Перемещение скейтборда вперед/назад
        float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveForward);

        // Поворот скейтборда влево/вправо
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationY, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "obstacle")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    /*private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
    }*/
}

