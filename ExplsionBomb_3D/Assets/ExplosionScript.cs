using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour 
{
    [Tooltip("Area de ação da explosão.")]
    public float radius = 5.0f;
    [Tooltip("Cor para identificar area de alcance da bomba")]
    public Color colorRadius;
    [Tooltip("Poder da explosão.")]
    public float power = 15.5f;
    private Vector3 posBomb;
    [Tooltip("Cor para identificar onde está o centro da bomba")]
    public Color colorPosBomb;
    [Tooltip("Ajuste na posição aparente da explosão para dar a impressão de levantar os objetos.")]
    public float upwardForce;
    private Collider[] colliders;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        ExplosionEffect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ExplosionEffect()
    {
        posBomb = transform.position;
        colliders = Physics.OverlapSphere(posBomb, radius);
        foreach (Collider hit in colliders)
        {
            rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, posBomb, radius, upwardForce, ForceMode.Impulse);
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = colorPosBomb;
        Gizmos.DrawSphere(transform.position, 0.1f);
        Gizmos.color = colorRadius;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
