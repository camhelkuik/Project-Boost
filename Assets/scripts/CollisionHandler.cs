using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Hit a friendly thing");
                break;
            case "Finish":
                Debug.Log("You did it, you finished!");
                break;
            case "Fuel":
                Debug.Log("Add fuel!!");
                break;
            default:
                ReloadLevel();
                break;
        }
    }

    private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
