using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFlicker : MonoBehaviour
{
    public float minIntensity = 0.5f;  // Minimum brightness of the star
    public float maxIntensity = 1.0f;  // Maximum brightness of the star
    public float flickerSpeed = 2.0f;  // Speed of flickering
    private SpriteRenderer spriteRenderer;
    private float flickerTimer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        flickerTimer = Random.Range(0, Mathf.PI * 2);  // Randomize the flicker start time
    }

    void Update()
    {
        // Make the stars flicker by adjusting the alpha over time
        float alpha = Mathf.Lerp(minIntensity, maxIntensity, Mathf.Sin(flickerTimer * flickerSpeed));
        Color color = spriteRenderer.color;
        color.a = alpha;
        spriteRenderer.color = color;

        flickerTimer += Time.deltaTime;
    }
}
