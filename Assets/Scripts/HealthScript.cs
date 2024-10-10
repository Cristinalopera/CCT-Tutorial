using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  // Add this to use the new Input System


public class HealthScript : MonoBehaviour
{

    [field: SerializeField] 
    public int Health { get; private set; } 
    
    private int maxHealth; 
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = Health; 
    }
    
    public void ApplyDamage(int damage) 
    { 
        // you can do other calculations here as well (e.g. armor)
        Health = Mathf.Clamp(Health - damage, 0, maxHealth); 
    } 
}