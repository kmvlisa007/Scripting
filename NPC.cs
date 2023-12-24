using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 3;
    public int level = 1;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("Жизней: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z -= speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
