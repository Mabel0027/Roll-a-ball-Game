using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Agregamos
using UnityEngine.UI;
public class JugadorController : MonoBehaviour
{
    private Rigidbody rb;
    private int contador;
    public Text textoContador, textoGanar;
    public float velocidad;
    private Canvas canvas; // Nueva variable para referenciar el Canvas

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        setTextoContador();
        textoGanar.text = "";
        canvas = FindObjectOfType<Canvas>(); // Encuentra el Canvas en la escena
    }

    // ... Tu código existente ...

    void setTextoContador()
    {
        if (textoContador != null)
        {
            textoContador.text = "Contador: " + contador.ToString();
            if (contador >= 12)
            {
                MostrarTextoGanar();
            }
        }
        else
        {
            Debug.LogError("El componente TextoContador no está asignado en el Inspector.");
        }
    }

    void MostrarTextoGanar()
    {
        textoGanar.text = "¡Ganaste!";
        if (canvas != null)
        {
            textoGanar.fontSize = 40; // Ajusta el tamaño del texto como desees
            textoGanar.rectTransform.position = new Vector3(canvas.pixelRect.width / 2, canvas.pixelRect.height / 2, 0);
        }
        else
        {
            Debug.LogError("No se encontró el componente Canvas.");
        }
    }
}
