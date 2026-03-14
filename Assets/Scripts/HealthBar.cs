using UnityEngine;

public class HealthBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public RectTransform mask;
    public Health health;

    private float originalWidth;
    void Start()
    {
        originalWidth = mask.sizeDelta.x;
    UpdateHealthValue();
    health.onHealthChanged += UpdateHealthValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateHealthValue()
    {
    float scale = (float)health.healthPoint / health.defaultHealthPoint;
    mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }
}
