using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFloorManager : MonoBehaviour
{
    public float duree;
    private float timer = 0f;
    private Collision col;
    private void OnCollisionExit(Collision collision)
    {
        col = collision;
        timer = 0f; // necessite de rajouter une condition de temps sinon des le moindre rebond on a un appel au respawn, ce qui creait des respawn de plusieurs balles en meme temps
        
    }
    private void Update()
    {
        
        timer += Time.deltaTime;
        if (timer > duree)
        {
            if (col.gameObject.tag == "Ball" && timer > duree)
            {
                col.gameObject.GetComponent<BallFall>().Fall();
            }
        }

    }
}
