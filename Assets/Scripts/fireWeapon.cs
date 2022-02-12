using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireWeapon : MonoBehaviour
{

    public Rigidbody bulletType; // get bullet rigidbody
    public Transform spawnPoint; // spawn point for bullet

    public int multiplier; // bullet travel speed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireWeapon()
    {
        Rigidbody bulletInstance;
        bulletInstance = Instantiate(bulletType, spawnPoint.position, spawnPoint.transform.rotation) as Rigidbody;
        bulletInstance.AddForce(spawnPoint.forward * multiplier);
    }
}
