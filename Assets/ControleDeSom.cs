using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControleDeSom : MonoBehaviour
{
    // Start is called before the first frame update
    public List<AudioSource> _sonsMenu = new List<AudioSource>();
    public List<AudioSource> _sonsMusicas = new List<AudioSource>();
    public List<AudioSource> _sonsGames = new List<AudioSource>();
    [SerializeField] bool _somMenuMute;
    [SerializeField] bool _somMusicaMute;
    [SerializeField] TextMeshProUGUI  _textSomMenu;
    [SerializeField] TextMeshProUGUI _textSomMusica;
    [SerializeField] bool _somMuteMult;
    [SerializeField] TextMeshProUGUI _textSomMult;

    public void ListSomMenu()
    {
        _somMenuMute = !_somMenuMute;
        if (_somMenuMute)
        {
            _textSomMenu.text = "Mute";
        }
        else 
        {
            _textSomMenu.text = "Som";
        }
        for (int i=0;i<_sonsMenu.Count;i++)
        {
            _sonsMenu[i].mute = _somMenuMute;
        }

    }
    public void ListSomMusica()
    {
        _somMusicaMute = !_somMusicaMute;
        if (_somMusicaMute)
        {
            _textSomMusica.text = "Som";
            
            for (int i = 0; i < _sonsMusicas.Count; i++)
            {
                _sonsMusicas[i].Play();
            }
        }
        else
        {
            _textSomMusica.text = "Mute";
            for (int i = 0; i < _sonsMusicas.Count; i++)
            {
                _sonsMusicas[i].Stop();
            }
        }
       

    }
    public void ListSomMults()
    {
        _somMuteMult = !_somMuteMult;
        if (_somMuteMult)
        {
            _textSomMult.text = "Multado Bola";

           
        }
        else
        {
            _textSomMult.text = "Som Bola";

        }
        
        for (int i = 0; i < _sonsGames.Count; i++)
        {
            _sonsGames[i].mute = _somMuteMult;
        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
