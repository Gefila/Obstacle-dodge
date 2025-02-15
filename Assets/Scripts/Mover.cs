using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float yValue = 0f;
    public float xValue = 0f;
    public float zValue = 0f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue,  yValue, zValue);
    }
}
