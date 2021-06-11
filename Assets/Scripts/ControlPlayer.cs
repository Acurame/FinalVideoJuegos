using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    Rigidbody2D Player;
    
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Move = Input.GetAxis("Vertical");
        Player.velocity = new Vector2(Player.velocity.x,Move * Speed * Time.deltaTime);
    }
}
