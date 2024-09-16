using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaControl : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _audioSource;
    public  AudioClip _sonsHit;
    public AudioClip _sonsAtack;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            Debug.Log("Tocou no chão");
            _audioSource.clip = _sonsHit;
            _audioSource.Play();
        

        }
            

        
    }
    void Start()
    {
        _audioSource=GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
