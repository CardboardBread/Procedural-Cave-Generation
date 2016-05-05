using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    Rigidbody rigidbody;
    Vector3 velocity;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        velocity = new Vector3(0, Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal")).normalized * 10;
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
    }
}