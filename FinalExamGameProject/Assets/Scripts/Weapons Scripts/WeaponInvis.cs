using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInvis : MonoBehaviour
{
    public void ToggleInvisibilty()
    {
        Render rend = gameObject.GetComponent<Renderer>();
        if (rend.enabled)
            rend.enabled = false;
        else
            rend.enabled = true; 
    }
}

