using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObstaculo : MonoBehaviour{
    public float Velocidad_Blo=3;
    public float Velocidad_Obs=3;
    public int Val=0;
    public float i = 0;
    // Start is called before the first frame update
    void Start(){ 
        
    }
   
    // Update is called once per frame
    void Update(){
        if (LogicaPuntaje.Puntaje > 49 && LogicaPuntaje.Puntaje < 100){
            i = 1;
        }
        else if (LogicaPuntaje.Puntaje > 100 && LogicaPuntaje.Puntaje < 150){
            i = 2;
        }
        else if (LogicaPuntaje.Puntaje > 149 && LogicaPuntaje.Puntaje < 200){
            i = 3; 
        }
        else if (LogicaPuntaje.Puntaje > 199 && LogicaPuntaje.Puntaje < 250){
            i = 4;
        }
        else if (LogicaPuntaje.Puntaje > 249 && LogicaPuntaje.Puntaje < 300){
            i = 5; 
        }
        else if (LogicaPuntaje.Puntaje > 299 && LogicaPuntaje.Puntaje < 350){
            i = 6;
        }
        else if (LogicaPuntaje.Puntaje > 349 && LogicaPuntaje.Puntaje < 400){
            i = 7;
        }


        if (Val >0)
        {

            transform.position += Vector3.left * (Velocidad_Obs+i) * Time.deltaTime;

        }
        else
        {
            transform.position += Vector3.left * Velocidad_Blo * Time.deltaTime;
        }
        
    }
}
