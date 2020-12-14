using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Player Player;
    AudioSource _audio;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.Jump();
        }
    }
}