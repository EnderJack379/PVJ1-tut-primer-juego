using UnityEngine;


public class Player
{
    private float velocidad;
    private float aceleracion;
    private float velocidadActual;

    public Player(float velocidad, float aceleracion)
    {
        this.velocidad = velocidad;
        this.aceleracion = aceleracion;
        this.velocidadActual = 2f;
    }


    public float Velocidad
    { get => velocidad; set => velocidad = value; }

    public float Aceleracion
    { get => aceleracion; set => aceleracion = value; }

    public float VelocidadActual
    { get => velocidadActual; set => velocidadActual = value; }


}




