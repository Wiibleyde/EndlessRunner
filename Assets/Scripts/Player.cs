using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    private Vector3 direction;

    public float jumpForce = 8f;

    private void Update()
    {
        if (GetComponent<Rigidbody2D>().velocity == Vector2.zero) {
            if (Input.GetKeyUp(KeyCode.Space)) {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle")) {
            Debug.Log("Game Over");
        }
    }

}
 