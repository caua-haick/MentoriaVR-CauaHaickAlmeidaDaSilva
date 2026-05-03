using UnityEngine;

public class ControleLuz : MonoBehaviour
{
    // Arraste a sua 'luz-abajur' para cá no Unity
    public GameObject luzDoAbajur; 

    // Esta função será chamada pelo botão de Poke
    public void AlternarLuz()
    {
        if (luzDoAbajur != null)
        {
            // Se está ativa, desativa. Se está desativada, ativa.
            luzDoAbajur.SetActive(!luzDoAbajur.activeSelf);
        }
    }
}