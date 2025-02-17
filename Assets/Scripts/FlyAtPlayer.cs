using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform player;
    [SerializeField] float speed = 10f;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, playerPosition, Time.deltaTime * speed);
    }
}
