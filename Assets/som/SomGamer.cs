using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomGamer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ControleDeSom _somControle;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] bool _somMenu;
    [SerializeField] bool _somMusica;
    [SerializeField] bool _somGamer;
    void Start()
    {
        _somControle=Camera.main.GetComponent<ControleDeSom>();
        _audioSource=GetComponent<AudioSource>();
        if (_somMenu == true)
        {
            _somControle._sonsMenu.Add(_audioSource);
        }
       else if (_somMusica == true)
        {
            _somControle._sonsMusicas.Add(_audioSource);
        }
        else if (_somGamer == true)
        {
            _somControle._sonsGames.Add(_audioSource);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
