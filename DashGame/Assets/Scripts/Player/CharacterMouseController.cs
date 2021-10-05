using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouseController : MonoBehaviour
{
    [SerializeField] private CharacterMovement _characterMovement;
    [SerializeField] private float _minSwipeLength;

    private Vector2 _mouseUpPosition;
    private Vector2 _mouseDownPosition;


    private Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private bool checkSwipeVector()
    {
        if (Mathf.Abs((_mouseUpPosition - _mouseDownPosition).magnitude) > _minSwipeLength)
            return true;
        else 
            return false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 0.5f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            _mouseDownPosition = GetMousePosition();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            _mouseUpPosition = GetMousePosition();
            if (checkSwipeVector() == true)
                _characterMovement.TryMoveToPosition((Vector2)transform.position + (_mouseUpPosition - _mouseDownPosition));
        }
    }
}
