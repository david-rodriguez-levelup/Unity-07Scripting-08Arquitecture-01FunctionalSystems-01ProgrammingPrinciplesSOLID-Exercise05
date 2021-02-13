using System;
using UnityEngine;

public class DamageSourceSensor : MonoBehaviour
{

    [SerializeField] float damageRatio = 1f;

    public event Action<float> OnDamageDetected;

    private void Start()
    {
        // Intentionally left empty to allow enable/disable from the Inspector.
    }

    private void OnCollisionEnter(Collision collision)
    {
        DetectDamage(collision.gameObject);
    }

    private void OnTriggerEnter(Collider collider)
    {
        DetectDamage(collider.gameObject);
    }

    private void DetectDamage(GameObject gameObject)
    {
        if (enabled)
        {
            DamageSourceAction damageSourceAction = gameObject.GetComponent<DamageSourceAction>();
            if (damageSourceAction != null)
            {
                OnDamageDetected?.Invoke(damageSourceAction.Damage * damageRatio);
            }
        }
    }

}
