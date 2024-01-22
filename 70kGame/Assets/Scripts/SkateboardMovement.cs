using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class SkateboardMovement : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;
    public int coins;
    public GameObject losePanel;
    public TextMeshProUGUI coinsText;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject player;

    private void Awake()
    {
        coinsText.text = PlayerPrefs.GetInt("Coin").ToString();
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //Time.timeScale = 1;
    }

    private void Update()
    {
   
        // Перемещение сноуборда вперед/назад
        //float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Поворот сноуборда влево/вправо
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationY, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins = PlayerPrefs.GetInt("Coin");
            PlayerPrefs.SetInt("Coin", coins + 1);
            coinsText.text = (coins + 1).ToString();
            Destroy(other.gameObject);
            audioSource.PlayOneShot(audioClip);
        }
        if (other.gameObject.tag == "obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}

