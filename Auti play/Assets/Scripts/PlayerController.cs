using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f; // Ajusta la velocidad de movimiento según tus preferencias.

    void Update()
    {
        // Captura las entradas del teclado para mover el OVRCameraRig.
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula el vector de movimiento.
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);

        // Aplica el movimiento al OVRCameraRig.
        transform.Translate(movimiento * velocidadMovimiento * Time.deltaTime);
    }
}