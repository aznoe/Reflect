using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime = 20f;

    private Transform player;
    //private Vector3 target;
    private Rigidbody rb;

    Vector3 lastVelocity;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;


        rb = GetComponent<Rigidbody>();
        transform.LookAt(player);
        rb.AddForce(rb.transform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, lifeTime);

    }

    private void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            DestroyProjectile();
        }
        else if (other.CompareTag("Enemy"))
        {
            DestroyProjectile();
        }
        
    }

    

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
