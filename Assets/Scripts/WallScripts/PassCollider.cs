using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PassCollider : MonoBehaviour
{
    public AudioClip pointSound;
    private Text _scoreCounter;
    AudioSource _audio;
    
    
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _scoreCounter = GameObject.FindWithTag("ScoreCounter").GetComponent<Text>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _audio.PlayOneShot(pointSound);
            _scoreCounter.text = (int.Parse(_scoreCounter.text.ToString()) + 1).ToString();
        }
    }
}
