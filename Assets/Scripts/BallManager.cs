using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 10.0f;
    Rigidbody m_Rigidbody;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    private void Putting(Vector3 offset)
    {
        m_Rigidbody.AddForce(offset * movementSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Putting(Camera.main.transform.forward);
        }
        if (Input.GetKey(KeyCode.R))
        {
            gameObject.GetComponent<BallFall>().Fall();
        }
    }
}
