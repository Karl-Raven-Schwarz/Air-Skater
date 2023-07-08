using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuntajeRecord : MonoBehaviour{

    // Start is called before the first frame update
    void Start(){
        GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("Record Score", 0).ToString();
    }

    // Update is called once per frame
    void Update(){
        if(LogicaPuntaje.Puntaje > PlayerPrefs.GetInt("Record Score", 0)){
            PlayerPrefs.SetInt("Record Score", LogicaPuntaje.Puntaje);
            GetComponent<TextMeshProUGUI>().text = LogicaPuntaje.Puntaje.ToString();
        }
        

    }

    
}
