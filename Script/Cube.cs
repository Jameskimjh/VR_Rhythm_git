using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;
    private void Awake()
    {
        speed = Random.Range(3f, 5f);
    }
    private void Update()
    {
        transform.position += Time.deltaTime * transform.forward * speed;

    }
}
