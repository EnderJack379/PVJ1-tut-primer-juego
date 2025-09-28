using UnityEngine;
/// <summary>
/// Permite el comportamiento de movimiento del jugador.
/// </summary>


public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary> Fuerza de movimiento del jugador. 
    private Vector3 fuerzaPorAplicar;
    /// <summary> Representa el tiempo que ha trancurrido desde la ultima vez que se aplico una fuerza al jugador.
    private float tiempoDesdeUltimaFuerza;
    /// <summary> Indica cada cuanto tiempo se aplica una fuerza al jugador.
    private float intervaloTiempo;
    #endregion



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 5f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar, ForceMode.Impulse);
            tiempoDesdeUltimaFuerza = 0f;
        }

    }
}
