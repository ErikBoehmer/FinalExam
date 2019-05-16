using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryWeaponAfterTime : MonoBehaviour
{
    public GameObject player;
    private GameObject WeaoibWeCollidedWith;
    private Collider ColliderforTheWeaponWeCollidedWith;
    private Vector3 playerPos;
    private Quaternion playerRot;
    private Transform playerTransform;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.playerPos = collision.gameObject.transform.position;

            Destroy(collision.gameObject);
        }
    }
}
