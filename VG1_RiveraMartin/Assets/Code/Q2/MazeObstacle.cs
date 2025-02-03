using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeObstacle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.GetComponent<RotatingShipController>()) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
