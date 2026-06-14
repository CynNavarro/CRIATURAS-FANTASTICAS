using UnityEngine;
using UnityEngine.Events;

public class ButtonBoolUnityEvent : MonoBehaviour
{
    [Header("Estado")]
    [SerializeField] private bool estado;

    [Header("Eventos")]
    [SerializeField] private UnityEvent onTrue;
    [SerializeField] private UnityEvent onFalse;

    public void CambiarEstado()
    {
        estado = !estado;

        if (estado == true)
        {
            onTrue.Invoke();
        }
        else
        {
            onFalse.Invoke();
        }
    }
}