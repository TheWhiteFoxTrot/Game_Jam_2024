using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObjectController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on the target object.");
        }
    }

    public void ChangeSpriteImage(Sprite newSprite)
    {
        // Change the sprite image
        if (spriteRenderer != null && newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}
