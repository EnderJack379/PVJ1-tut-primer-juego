using UnityEngine;

public class MovimientoLateral : IMovementStrategy
    {
    public void Move(Transform target, Player player)
    {
        float direccion = Input.GetAxis("Horizontal") * player.Velocidad * Time.deltaTime ;
        target.Translate(direccion, 0, 0);
    }
}