using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GunScript : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 initialPos = Camera.main.transform.position + Camera.main.transform.forward * 2;

            GameObject bullet = Instantiate(bulletPrefab, initialPos, Quaternion.identity);
            
            bullet.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 50;
        }
    }
}