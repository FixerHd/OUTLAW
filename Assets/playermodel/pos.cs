using UnityEngine;

public class BloquearPosicion : MonoBehaviour
{
    // Declarar un booleano para controlar si la posici�n est� bloqueada o no.
    public bool posicionBloqueada = true;
    public GameObject player;

    void Update()
    {

        // Bloquear la posici�n si posicionBloqueada es verdadero.
        if (posicionBloqueada)
        {
            // Configurar la posici�n a un valor fijo (por ejemplo, (0, 0, 0)).
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y-1, player.transform.position.z);
        }
    }
}

