using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementWASD : MonoBehaviour

{
    // velocidad de movimiento del jugador
    public float Speed = 5f;
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
            // Detectar las teclas de movimiento horizontal(solo A y D)

            if (keyboard.dKey.isPressed) moveX = 1f;
            if (keyboard.aKey.isPressed) moveX = -1f;

            //detectar las teclas de movimiento vertical (solo W y S)
            
            if (keyboard.wKey.isPressed) moveY = 1f;
            if (keyboard.sKey.isPressed) moveY = -1f;

            
            }

                // creamos el movimiento
                Vector3 movement = new Vector3(moveX, moveY, 0);

                // movemos el sprite
                transform.Translate(movement * Speed * Time.deltaTime);
            
                }


            }
        
