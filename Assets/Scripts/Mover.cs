using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float movementSpeed = 0f;

    void Start()
    {
        printInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime;
        Vector3 movement = new Vector3(moveX, 0f, moveZ) * movementSpeed;
        transform.Translate(movement);
    }

    void printInstruction()
    {
        Debug.Log("Selamat Datang di game saya");
        Debug.Log("Tekan WASD untuk menggerakkan karakter");
    }
}
