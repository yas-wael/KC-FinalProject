using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipscript : MonoBehaviour
{
    SpriteRenderer sprite;
    bool faceRight = true;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Flipplayer();
    }

    void Flipplayer()
    {
        if (Input.GetKeyDown(KeyCode.D) && faceRight == false)
        {
            sprite.flipX = false;
            faceRight = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && faceRight == true)
        {
            sprite.flipX = true;
            faceRight = false;
        }
    }
}
