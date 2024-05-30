using UnityEngine.UI;

public interface ICommonFunction
{
    public void DelegateButtonEvent(Button button);
    public void OnInit(DelegateEventData data);
    public void OnReset();
}
