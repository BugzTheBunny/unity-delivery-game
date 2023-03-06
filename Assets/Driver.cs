using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   

    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float slowSpeed = 15f;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,speedAmount,0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "SpeedBoost") {
            moveSpeed = boostSpeed;
        } 
    }

}
