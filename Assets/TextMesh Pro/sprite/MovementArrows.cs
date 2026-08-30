using UnityEngine;
using UnityEngine.InputSystem;

public class MovementArrows : MonoBehaviour
{
    // velocidad de movimiento del jugador
    public float Speed = 15f;
    public void SetSpeed(float newSpeed)
    {
        Speed = newSpeed;
    }
    void Update()
    {

        float moveX = 0f;
        float moveY = 0f;

        // Detectar el teclado 

        Keyboard keyboard = Keyboard.current;

        if (keyboard != null)
        {
            // Detectar las teclas de movimiento horizontal(solo rightArrow y leftArrow)

            if (keyboard.rightArrowKey.isPressed) moveX = 1f;
            if (keyboard.leftArrowKey.isPressed) moveX = -1f;

            //detectar las teclas de movimiento vertical (solo upArrow y downArrow)

            if (keyboard.upArrowKey.isPressed) moveY = 1f;
            if (keyboard.downArrowKey.isPressed) moveY = -1f;

        }

        // creamos el vector de movimiento

        Vector3 movement = new Vector3(moveX, moveY, 0);

        // movemos el sprite
        transform.Translate(movement * Speed * Time.deltaTime);


    }

}
