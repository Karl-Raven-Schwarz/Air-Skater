using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicaMenu : MonoBehaviour{

    public AudioSource Music1;
    private AudioSource Music;
    // Start is called before the first frame update
    void Start()
    {
        Music = GetComponent<AudioSource>();
        Music.Play();

    }

    // Update is called once per frame
    void Update()
    {

        Music.volume = ControlVolumen.Volumen;
        Music1.volume = ControlVolumen.Volumen;
    }
}
