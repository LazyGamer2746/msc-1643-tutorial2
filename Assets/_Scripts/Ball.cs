using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip bounceSound;
    public float speed = 36.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        rb = GetComponent<Rigidbody>();

        float angle = Random.value * 44 - 22;

        if (Random.value < .5f)
        {
            angle += 180;
        }

        transform.eulerAngles += new Vector3(0, angle, 0);

        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision colosion)
    {
        if (!colosion.transform.CompareTag("Floor"))
        {
            AudioSource.PlayClipAtPoint(bounceSound, transform.position, 1.0f);
        }
        
    }
}
