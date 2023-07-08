using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaPuntaje : MonoBehaviour
{
    public static int Puntaje = 0;
    // Start is called before the first frame update
    void Start()
    {
        Puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = Puntaje.ToString();
    }

   
}
