using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaGeneradorObtaculos : MonoBehaviour
{
    
    private double TiempoIni = 0;
    public GameObject[] ArrayObstaculos;

    public float Altura;
    public double TiempoMax = .65;
    // Start is called before the first frame update
    int i=2 ,k=6;
    double x = .4;
    double j;
    void Start()
    {
        //   creando los obstaculos
        int Indice = Random.Range(0, ArrayObstaculos.Length );
        GameObject ObtaculoNuevo = Instantiate(ArrayObstaculos[Indice]);
        ObtaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-Altura, Altura), 0);
        Destroy(ObtaculoNuevo, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
         j=TiempoMax;
      //TiempoMax = r.NextDouble();
        if (TiempoIni > TiempoMax){
            //   creando los obstaculos
            int Indice = Random.Range(0, ArrayObstaculos.Length );

            while (j==TiempoMax || TiempoMax<.4){            
                if (LogicaPuntaje.Puntaje > 100 && LogicaPuntaje.Puntaje<150){
                    i = 2; k = 6;x = .2;
                }
                else if (LogicaPuntaje.Puntaje > 149 && LogicaPuntaje.Puntaje<200){
                    i = 2; k = 5; x =0.2;
                }
                else if (LogicaPuntaje.Puntaje > 199 && LogicaPuntaje.Puntaje < 250){
                    i = 2; k = 4; x = 0.2;
                }
                else if (LogicaPuntaje.Puntaje > 249 && LogicaPuntaje.Puntaje < 300){
                    i = 1; k = 4; x = 0.2;
                }
                else if (LogicaPuntaje.Puntaje > 299 && LogicaPuntaje.Puntaje < 350){
                    i = 1; k = 3; x = 0.2;
                }
                else if (LogicaPuntaje.Puntaje > 349 && LogicaPuntaje.Puntaje < 400){
                    i = 1; k = 2; x = 0.2;
                }

                TiempoMax = (Random.Range(i, k)/5.0) + x;
                
            }
            j = TiempoMax;
            

            GameObject ObtaculoNuevo = Instantiate(ArrayObstaculos[Indice]);
            ObtaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-Altura, Altura), 0);
            Destroy(ObtaculoNuevo, 10);
            TiempoIni = 0;
        }else
        {
            TiempoIni += Time.deltaTime;
        }
        
    }
}
