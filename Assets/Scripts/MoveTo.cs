using DG.Tweening;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration = 1f;

    private void Start()
    {
        transform.DOMove(_position, _duration);
    }
}
