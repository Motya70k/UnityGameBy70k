using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private roadspawner _roadSpawner;

    private void OnTriggerEnter(Collider other)
    {
        _roadSpawner.Spawn();
    }
}
