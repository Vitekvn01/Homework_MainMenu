using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine;

public class ScaleEnterElement : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float _scaleMultiplier;
    [SerializeField] private float _duration;

    private Vector3 _originalScale;

    private void Awake()
    {
        _originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(_originalScale * _scaleMultiplier, _duration).SetEase(Ease.OutBack);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(_originalScale, _duration).SetEase(Ease.OutBack);
    }
}
