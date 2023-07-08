using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlVolumen : MonoBehaviour{
    public Slider controlvol;
    public static float Volumen;
    // Update is called once per frame
    void Start()
    {
        controlvol.value =  PlayerPrefs.GetFloat("Volumen", 1);
    }
    void Update(){

        Volumen = controlvol.value;

        if (Volumen != PlayerPrefs.GetFloat("Volumen", 1))
        {
            PlayerPrefs.SetFloat("Volumen", controlvol.value);
            Volumen = controlvol.value;
        }

    }

    public void VolumenUpdate(){
        PlayerPrefs.GetFloat("Volumen", controlvol.value);
        PlayerPrefs.SetFloat("Volumen",controlvol.value );


    }
}
