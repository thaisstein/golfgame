using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float respawnTime;
    private Vector3 ballSpawn;
    public GameObject ballPrefab;
    void Start()
    {
        GameObject start = GameObject.FindGameObjectWithTag("Start");
        if (!start) return;
        ballSpawn = start.transform.position;
    }

    private IEnumerator RespawnBall()
    {
        yield return new WaitForSeconds(respawnTime);

        Instantiate(ballPrefab, ballSpawn, Quaternion.identity);
    }
    public void StartBallRespawn()
    {
        StartCoroutine(RespawnBall());
    }
}
