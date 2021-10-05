using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private bool _isMove = false;
    private Vector2 _targetPosition;

    #region MonoBehaviour
    private void FixedUpdate()
    {
        MoveUpdate();
    }
    #endregion

    public void TryMoveToPosition(Vector2 position)
    {
        if (CanMove() == true)
        {
            _isMove = true;
            Move(position);
        }
    }

    private void OnMoveComplete()
    {
        _isMove = false;
    }

    private bool CanMove()
    {
        return !_isMove;
    }

    private void MoveUpdate()
    {
        if (_isMove == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);

            if ((Vector2)transform.position == _targetPosition)
                OnMoveComplete();
        }
    }

    private void Move(Vector2 position)
    {
        _targetPosition = position;
    }
}
