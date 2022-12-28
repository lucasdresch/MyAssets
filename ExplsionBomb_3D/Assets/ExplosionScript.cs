using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour 
{
    [SerializeField, Tooltip("Area de ação da explosão.")]
    private float radius = 5.0f;
    [SerializeField, Tooltip("Poder da explosão.")]
    private float power = 15.5f;
    private Vector3 posBomb;
    private Collider[] colliders;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        posBomb = transform.position;
        colliders = Physics.OverlapSphere(posBomb, radius);
        foreach(Collider hit in colliders)
        {
            rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                print(hit.name);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
