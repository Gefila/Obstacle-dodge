using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && gameObject.tag != "Hit")
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            gameObject.tag = "Hit";
            Debug.Log("Something hit me: " + collision.gameObject.name);
        }
    }
}
