using UnityEngine;
using UnityEngine.InputSystem;

public class TurnAndColor: MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        // obtenemos el spriteRenderer para cambiar el color
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            //rotacion Q Y E
            if (keyboard.qKey.wasPressedThisFrame)
            {
                // rota10grados a la izquierda en sentido anti horario
                transform.Rotate(0, 0, 10f);
            }
            if (keyboard.eKey.wasPressedThisFrame)
            {
                // rota 10 grados a la derecha en sentido horario
                transform.Rotate(0, 0, -10f);
            }

            //cambio de color R G B
            if (keyboard.rKey.wasReleasedThisFrame)

            {
                if (spriteRenderer != null)
                {
                    // genera un color aleatorio
                    Color colorRandom = new Color(Random.value, Random.value, Random.value);
                    spriteRenderer.color = colorRandom;
                }
               }

            }


        }
    }
