using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletScript : MonoBehaviour
{
    public int Damage = 5;
    
    private void OnCollisionEnter(Collision other)
    {
        HealthScript healthScript = other.gameObject.GetComponent<HealthScript>();

        if (healthScript != null)
        {
            
        }
        
        Destroy(gameObject);
    }
}