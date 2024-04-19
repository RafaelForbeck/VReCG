using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    public void TurnOn()
    {
        spriteRenderer.enabled = true;
    }

    public void TurnOff()
    {
        spriteRenderer.enabled = false;
    }
}
