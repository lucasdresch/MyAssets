using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour 
{
    private float raio = 5.0f;
    private float power = 15.5f;
    private Vector3 posBomb;
    private Collider[] colliders;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        posBomb = transform.position;
        colliders = Physics.OverlapSphere(posBomb, raio);
        foreach(Collider hit in colliders)
        {
            print(hit.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
