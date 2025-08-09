using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButoonEffectController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        UIEffect componente = GetComponent<UIEffect>();
        componente.transitionAutoPlaySpeed = 1;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        UIEffect componente = GetComponent<UIEffect>();
        componente.transitionAutoPlaySpeed = 0;
    }
}
