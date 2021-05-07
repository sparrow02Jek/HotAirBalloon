using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player1))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float min;// ограничение миним
    [SerializeField] private float max;//ограничение  максимаs
    [SerializeField] private float _speed = 0.1f;

    private Vector3 _lastMousePos;
    private Camera _camera;


    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,min,max),transform.position.y,transform.position.z);//что бы не выходило за грагицы экрана
        
        if (Input.GetMouseButton(0))
        {
            Move();
        }
    }

    
    private void Move()
    {
        float velocity;

        Vector3 currentMousePos = _camera.ScreenToWorldPoint(Input.mousePosition); // Текущая позиция мыши в глобальных кординатах
        float pos = _lastMousePos.x - currentMousePos.x; // Отнимаем текущую позицию от последней, тем самым узнаем направление движения мыши

        if (Mathf.Abs(pos) > 0) // Узнаем не стоит ли мыша на месте 
        {
            velocity = Mathf.Sign(pos); // Откидаем все и узнаем только знак (-145 -> -1, 145 -> 1)

            _lastMousePos = currentMousePos;
            
            transform.Translate(Vector3.left * velocity * _speed);
        }
    }
}

// P.S Сорри за мою орфографию
