using UnityEngine;

public class ControleComputador : MonoBehaviour
{
    public GameObject imagemTelaPC; 

    public void AlternarPC()
    {
        if (imagemTelaPC != null)
        {
            bool estado = imagemTelaPC.activeSelf;
            imagemTelaPC.SetActive(!estado);
        }
    }
}