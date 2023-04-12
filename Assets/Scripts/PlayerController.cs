using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Parametro de movimiento"), Space]
    [Tooltip("Velocidad de movimento")]
    public float speed;

    //refencia al valor del input axis horizontal
    private float h;

    //refencia al valor del input axis vertical
    private float v;
    [Header("Límites de pantalla"), Space]
    [Tooltip("Límite de movimiento en el eje X")]
    [Tooltip("Límte de movimiento en el eje Y")]
    public float yLimit;

    //Referencias
    //Referencia al rigidbody 2D
    private Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Recuperamos los valores de los axishorizontal y vertical
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        
    }
    private void FixedUpdate() {

        Movement();

    }
    /// <summary>
    /// Método que se encarga de realizar el movimiento del jugador
    /// </summary>
    private void 
        Movement() {
        
        //Generamos un vector de movimiento
        movement = new Vector2(h, v).normalized;

        //Aplicamos el movimiento sobre el jugador
        rb2d.MovePosition((Vector2)transform.position + Movement * speed * Time.deltaTime);






    }


}
