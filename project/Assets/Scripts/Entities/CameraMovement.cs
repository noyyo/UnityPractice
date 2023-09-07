using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    private Transform _character;
    private Camera _camera;

    private void Awake()
    {
        _character = FindFirstObjectByType<PlayerInput>().transform;
        _camera = Camera.main;
    }
    private void LateUpdate()
    {
        _camera.transform.SetPositionAndRotation(new Vector3(_character.transform.position.x, _character.transform.position.y, transform.position.z), transform.rotation);
        
    }
}
