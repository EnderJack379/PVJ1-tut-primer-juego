using UnityEngine;

public class MovimientoLateral : IMovementStrategy
    {
    public void Move(Transform target, Player player, float direccion)
    {
       // float direccion = Input.GetAxis("Horizontal") * player.Velocidad * Time.deltaTime ;
        //target.Translate(direccion, 0, 0);

        target.Translate(direccion * player.Velocidad * Time.deltaTime,0 ,0 );

    }
}