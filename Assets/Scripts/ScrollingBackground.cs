using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Renderer bgRenderer;
public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() =>
bgRenderer.material.mainTextureOffset =
new Vector2(0, Time.time * speed);
}
