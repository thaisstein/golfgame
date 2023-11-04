using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFall : MonoBehaviour
{
    public void Fall()
    {
        FindObjectOfType<Respawn>().StartBallRespawn();
        Destroy(gameObject);
    }
}
