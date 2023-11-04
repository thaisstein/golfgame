using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    [SerializeField] private int nextSceneIndex;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
