using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponPickup : MonoBehaviour
{
    public GameObject myWeapon;
    public GameObject WeaponOnGround;
    void Start()
    {
        myWeapon.SetActive(false);
    }
    void OnTriggerEnter(Collider _collider)
    {
        if(_collider.gameObject.tag == "Player")
        {
            myWeapon.SetActive(true);
            WeaponOnGround.SetActive(false);
        }
    }
}
