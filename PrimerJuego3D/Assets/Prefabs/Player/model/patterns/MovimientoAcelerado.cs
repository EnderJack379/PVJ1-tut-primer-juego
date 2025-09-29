
using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
    {
    private float velocidadActual = 0f;

    public void Move(Transform target, Player player)
    {
        float input = Input.GetAxis("Horizontal");
        velocidadActual += input * player.Aceleracion * Time.deltaTime ;   
        velocidadActual = Mathf.Clamp(velocidadActual, -player.Velocidad, player.Velocidad);
        player.VelocidadActual = velocidadActual;
        target.Translate(velocidadActual * Time.deltaTime, 0, 0);
    }


}