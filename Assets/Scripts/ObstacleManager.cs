using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private float leftEdge;
    public float speed = 1f;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;
    }

    private void Update()
    {
        // Increase the speed of the obstacle over time
        speed += Time.deltaTime / 100f;
        transform.position += Vector3.left * speed * Time.deltaTime ;

        if (transform.position.x < leftEdge) {
            if (gameObject.CompareTag("Obstacle"))
            {
                GameObject.Find("ScoreText").GetComponent<Score>().UpdateScore(1);
            }
            Destroy(gameObject);
        }
    }
}
