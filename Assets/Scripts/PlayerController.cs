using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    public float RotationSpeed = 5f;
    private float _rotationY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _characterController = GetComponent<CharacterController>();  
    }
    public void Rotate(Vector2 rotationVector)
    {
        _rotationY += rotationVector.x * RotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, _rotationY, 0);
    }
       
}
