
using UnityEngine;

public interface IMovementStrategy
{
  public void Move(Transform targe, Player player, float direccion);
}