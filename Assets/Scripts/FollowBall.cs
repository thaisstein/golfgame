using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public float speed;
    private Transform target;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        target = ball.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ball)
        {
            ball = GameObject.FindGameObjectWithTag("Ball");
            target = ball.transform;
        }
        if (!ball) return;
        transform.LookAt(target.position);
        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(target.position, Vector3.up, Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(target.position, Vector3.up, -Time.deltaTime * speed);
        }
        
    }
}
