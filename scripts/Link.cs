using UnityEngine;

public class Link : MonoBehaviour
{
    [SerializeField] private string url;

    public void AbrirPagina()
    {
        Application.OpenURL(url);
    }
}