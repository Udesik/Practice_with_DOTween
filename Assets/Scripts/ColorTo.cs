using DG.Tweening;
using UnityEngine;

public class ColorTo : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private void Start()
    {
        GetComponent<Renderer>().material.DOColor(_color, _duration);
    }
}
