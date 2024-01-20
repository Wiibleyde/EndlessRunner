using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Vector3 direction;

    private float jumpForce = 6f;
    private float backflipTorque = 1.5f;

    private void Update()
    {
        if (GetComponent<Rigidbody2D>().velocity == Vector2.zero)
        {
            if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.UpArrow))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                // GetComponent<Rigidbody2D>().AddTorque(backflipTorque, ForceMode2D.Impulse);

            }
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10), ForceMode2D.Impulse);

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);

        }
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            GameObject.Find("ScoreText").GetComponent<Score>().UpdateScore(1);
        }
    }
}
    

