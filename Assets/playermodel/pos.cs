using UnityEngine;

public class BloquearPosicion : MonoBehaviour
{
    // Declarar un booleano para controlar si la posición está bloqueada o no.
    public bool posicionBloqueada = true;
    public GameObject player;

    void Update()
    {

        // Bloquear la posición si posicionBloqueada es verdadero.
        if (posicionBloqueada)
        {
            // Configurar la posición a un valor fijo (por ejemplo, (0, 0, 0)).
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y-1, player.transform.position.z);
        }
    }
}

