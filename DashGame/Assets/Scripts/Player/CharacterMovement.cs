using DG.Tweening;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _movementTime;


    public void MoveToPosition(Vector2 position)
    {
        transform.DOMove(position, _movementTime);
    }
}
