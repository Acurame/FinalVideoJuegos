using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    public float Speed = 1.5f;
    private Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.mainTextureOffset = render.material.mainTextureOffset + new Vector2(Speed * Time.deltaTime, 0);
    }
    
}
