using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitscanScript : MonoBehaviour 
{
    [SerializeField]
    private float maxRange;
    
    [SerializeField]
    private int damage;
    
    void Update() {
        
        RaycastHit hitObj;
        
        Vector3 initialPos = transform.position; // this script is meant to be attached on a game object located at the weapon's barrel
        Vector3 bulletDir = Camera.main.transform.forward;
        
        if (Physics.Raycast(initialPos, bulletDir, out hitObj, maxRange))
        {
            if (hitObj.collider.GetComponent<HealthScript>())
                hitObj.collider.GetComponent<HealthScript>().ApplyDamage(damage);
        }
        
    }    
} 
