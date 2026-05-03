using UnityEngine;

public class ControleTV : MonoBehaviour
{
    public GameObject telaDaTV; 

    public void AlternarTV()
    {
        if (telaDaTV != null)
        {
            // Inverte o estado ativo do objeto (Liga/Desliga)
            bool estado = telaDaTV.activeSelf;
            telaDaTV.SetActive(!estado);
        }
    }
}