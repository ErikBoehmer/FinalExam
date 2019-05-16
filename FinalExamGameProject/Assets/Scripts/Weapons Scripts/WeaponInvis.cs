using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInvis : MonoBehaviour
{

    private ref_deonly render;

    // Start is called before the first frame update
    void Awake()
    {
        this.render = this.GetComponent<ref_deonly>(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
