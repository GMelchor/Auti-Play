using UnityEngine;

public class RotarCamaraConMouse : MonoBehaviour
{
    public float velocidadRotacion = 2.0f; // Ajusta la velocidad de rotación según tus preferencias.

    void Update()
    {
        // Captura el movimiento del ratón.
        float movimientoHorizontal = Input.GetAxis("Mouse X");
        float movimientoVertical = Input.GetAxis("Mouse Y");

        // Calcula el ángulo de rotación en los ejes X e Y.
        float rotacionX = -movimientoVertical * velocidadRotacion;
        float rotacionY = movimientoHorizontal * velocidadRotacion;

        // Obtiene la transformación de OVRCameraRig.
        Transform rigTransform = transform;

        // Aplica la rotación al OVRCameraRig.
        rigTransform.Rotate(rotacionX, rotacionY, 0);
    }
}