using UnityEngine;
/// <summary>
/// Permite el comportamiento de movimiento del jugador.
/// </summary>


public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary> 
    /// Fuerza de movimiento del jugador.
    /// <summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary> 
    /// Representa el tiempo que ha trancurrido desde la ultima vez que se aplico una fuerza al jugador.
    /// <summary>
    private float tiempoDesdeUltimaFuerza;
    /// <summary> 
    /// Indica cada cuanto tiempo se aplica una fuerza al jugador.
    /// <summary>
    private float intervaloTiempo;
    /// <summary>
    /// Representa la estrategia de movimiento lateral del jugador.
    /// </summary>
    private IMovementStrategy strategy;
    private Player player;
    private Rigidbody rb;

    #endregion

    #region Ciclo de vida del script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 5f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        player = new Player(10f, 10f);

        rb = GetComponent<Rigidbody>();

        SetStrategy(new MovimientoAcelerado());

    }


    public void MovePlayer()
    {
        strategy.Move(transform, player);
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
                if (rb != null)
               { 
              rb.AddForce(fuerzaPorAplicar, ForceMode.Impulse);
            }
            
            tiempoDesdeUltimaFuerza = 0f;
        }

    }

    private void Update()
    {
        // Llama al movimiento lateral constantemente
        MovePlayer();
    }


    #endregion

    #region Lógica del script
    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }
    #endregion
}
