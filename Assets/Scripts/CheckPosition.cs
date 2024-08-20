using UnityEngine;

public class PositionChecker : MonoBehaviour
{
    [field:SerializeField] public Vector3 _lastPosition { get; private set; }  // Almacena la �ltima posici�n conocida
    private bool _positionChanged = false; // Estado de si la posici�n ha cambiado

    void Start()
    {
        // Inicializar la �ltima posici�n con la posici�n actual al inicio
        _lastPosition = transform.position;
    }

    void Update()
    {
        // Comprobar si la posici�n ha cambiado
        CheckPositionChange();

        // Acci�n si la posici�n ha cambiado (ejemplo)
        if (_positionChanged)
        {
            Debug.Log("La posici�n ha cambiado.");
        }
    }

    public void CheckPositionChange()
    {
        // Comparar la posici�n actual con la �ltima posici�n almacenada
        if (transform.position != _lastPosition)
        {
            _positionChanged = true; // Marcar que la posici�n ha cambiado
            _lastPosition = transform.position; // Actualizar la �ltima posici�n conocida
        }
        else
        {
            _positionChanged = false; // No ha cambiado la posici�n
        }
    }

    // Funci�n que puedes usar para obtener si la posici�n cambi�
    public bool HasPositionChanged()
    {
        return _positionChanged;
    }
}
