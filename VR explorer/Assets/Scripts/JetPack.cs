using UnityEngine;
using System.Collections;

public class JetPack : MonoBehaviour
{
    float speed = 5.0f;
    Vector3 moveDir = Vector3.zero;
    float gravity = -9.8f;
    public float thrust;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") == 1)
        {
            rb.AddForce(transform.up * 50);
        }
        transform.Translate(moveDir);
    }
}