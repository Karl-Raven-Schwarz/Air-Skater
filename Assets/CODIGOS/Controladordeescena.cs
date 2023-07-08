using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Controladordeescena : MonoBehaviour {
    public GameObject Personaje;

    public GameObject[] BloquePreFab;

    /// Personalizado


    public double TiempoMax = 10;
    private double TiempoIni = 0;
    //   ------Direct V
    public GameObject CanvasPerdiste;

    

    // Start is called before the first frame update
    void Start() {

        // Optimizacion



        //    -------Direct V
        Time.timeScale = 1;

        //Anuncio



    }

    // Update is called once per frame
    void Update() {
        //while (Time.timeScale != 0){
        if (TiempoIni > TiempoMax){

           //  Generador de Fondo
            GameObject ObjetoBloque = Instantiate(BloquePreFab[0]);
            ObjetoBloque.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(ObjetoBloque, 28);


            TiempoIni = 0;
        
        }
        else{
            TiempoIni += Time.deltaTime;
        }

    }


    public void Perdiste(){
        //Anuncios


        LogicaPersonaje.perdiste += 1;
        Personaje.SetActive(false);
        CanvasPerdiste.SetActive(true);
        Time.timeScale = 0;


    }

    public void Reiniciar(){

        SceneManager.LoadScene(1);

    }
   
    

}
