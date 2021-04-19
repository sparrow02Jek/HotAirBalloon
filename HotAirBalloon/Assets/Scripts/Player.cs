using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 0.1f;

    private Vector2 _lastMousePos;
    private Camera _camera;
    private Vector2 _lastBalloonPos;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Move();
        }
    }


    private void Move()
    {
        float velocity;

        Vector2 currentMousePos = _camera.ScreenToWorldPoint(Input.mousePosition); // Текущая позиция мыши в глобальных кординатах
        transform.localPosition = currentMousePos;
    }
    
}