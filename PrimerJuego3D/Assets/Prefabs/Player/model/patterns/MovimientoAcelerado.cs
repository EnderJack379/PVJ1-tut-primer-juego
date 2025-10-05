 using System;
using System.IO;
using UnityEngine;
using UnityEngine.Windows;

public class MovimientoAcelerado : IMovementStrategy
    {
    private float velocidadActual = 0f;

    public void Move(Transform target, Player player, float direccion)
    {

        //float input = Input.GetAxis("Horizontal");
        //velocidadActual += input * player.Aceleracion * Time.deltaTime ;  

        velocidadActual += direccion * player.Aceleracion * Time.deltaTime;
        velocidadActual = Mathf.Clamp(velocidadActual, -player.Velocidad, player.Velocidad);
        player.VelocidadActual = velocidadActual;
        target.Translate(velocidadActual * Time.deltaTime, 0, 0);
    }


}