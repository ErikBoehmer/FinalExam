using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDestoryWentTouched : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("Trigger Collision:" + other.tag);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Weapon")
        {
            Destroy(collision.gameObject);
        }
    }
}
