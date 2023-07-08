using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour{
    public float Velocity = 1;
    private Rigidbody2D rb;
    public Controladordeescena controladorEscena;
    public static int perdiste = 0;
    private Animator miAnimacion;
    public AudioSource Salto;


    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        miAnimacion = GetComponent<Animator>();

        Salto.volume = ControlVolumen.Volumen;



    }

    // Update is called once per frame
    void Update(){
        float ComSalto=0;
        Saltando(ComSalto);


        Salto.volume = ControlVolumen.Volumen; 
        if (Input.GetMouseButtonDown(0)){
            ComSalto = 2;
            while (ComSalto>1) {
                Saltando(ComSalto);
                ComSalto = 0;
            }
  
            Salto.Play(); 
            rb.velocity = Vector2.up * Velocity;

        }
       
        if (transform.position.y>5.5 || transform.position.y < -5.5){

            controladorEscena.Perdiste();

        }


       
    }

    private void Saltando(float horizontal){
        miAnimacion.SetFloat("Salto", horizontal);
        
    }

    private void OnCollisionEnter2D(Collision2D collision){

       
        controladorEscena.Perdiste();
        
    }
}
