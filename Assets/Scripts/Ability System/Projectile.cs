using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    protected Rigidbody2D rb;
    protected Vector3 direction;
    public float force;
    [SerializeField] List<StatusEffect> _statusEffects;
    [SerializeField] private float projectileTimer;
    public GameObject parent;

    // increase sprite size
    // Start is called before the first frame update
    protected virtual void Start()
    {
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (projectileTimer > 0)
        {
            projectileTimer -= Time.deltaTime;
            return;
        }
        Destroy(this.gameObject);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other) {
        var statusEffectManager = other.GetComponent<StatusEffectManager>();
            statusEffectManager?.ApplyEffects(_statusEffects);
        
        Debug.Log($"Hit {other.gameObject.name}");

        Destroy(this.gameObject);
    }
}
