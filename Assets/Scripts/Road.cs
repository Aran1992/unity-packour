using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public int middleCount;

    void Start()
    {
        Vector2 sideSpriteSize = CreateLeft();
        float sumWidth = sideSpriteSize.x;
        float textureHeight = sideSpriteSize.y;
        for (int i = 0; i < middleCount; i++)
        {
            sumWidth = CreateMiddle(sumWidth);
        }
        sumWidth = CreateRight(sumWidth);

        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        collider.size = new Vector2(sumWidth, textureHeight / 2);
        collider.offset = new Vector2(sumWidth / 2, -textureHeight / 4);
    }

    Vector2 CreateLeft()
    {
        GameObject gameObject = new GameObject();
        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        string path = "ground/side";
        Texture2D texture = Resources.Load(path) as Texture2D;
        Rect rect = new Rect(0, 0, texture.width, texture.height);
        Vector2 pivot = new Vector2(0.5f, 0.5f);
        spriteRenderer.sprite = Sprite.Create(texture, rect, pivot);
        spriteRenderer.flipX = true;
        gameObject.transform.parent = transform;
        gameObject.transform.localPosition = new Vector2(spriteRenderer.size.x / 2, 0);
        return spriteRenderer.size;
    }

    float CreateMiddle(float sumWidth)
    {
        GameObject gameObject = new GameObject();
        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        string path = "ground/middle";
        Texture2D texture = Resources.Load(path) as Texture2D;
        Rect rect = new Rect(0, 0, texture.width, texture.height);
        Vector2 pivot = new Vector2(0.5f, 0.5f);
        spriteRenderer.sprite = Sprite.Create(texture, rect, pivot);
        gameObject.transform.parent = transform;
        gameObject.transform.localPosition = new Vector2(sumWidth + spriteRenderer.size.x / 2, 0);
        return sumWidth + spriteRenderer.size.x;
    }

    float CreateRight(float sumWidth)
    {
        GameObject gameObject = new GameObject();
        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        string path = "ground/side";
        Texture2D texture = Resources.Load(path) as Texture2D;
        Rect rect = new Rect(0, 0, texture.width, texture.height);
        Vector2 pivot = new Vector2(0.5f, 0.5f);
        spriteRenderer.sprite = Sprite.Create(texture, rect, pivot);
        gameObject.transform.parent = transform;
        gameObject.transform.localPosition = new Vector2(sumWidth + spriteRenderer.size.x / 2, 0);
        return sumWidth + spriteRenderer.size.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
