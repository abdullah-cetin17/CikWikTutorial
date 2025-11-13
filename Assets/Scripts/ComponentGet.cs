using UnityEngine;

public class ComponentGet : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    void Awake()
    {
        
    }
    private void Start()
    {
        _rigidbody.useGravity = false;
    }

}
