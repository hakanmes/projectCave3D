using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed = 0.1f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float moveThis = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0,moveThis));
    }

}
