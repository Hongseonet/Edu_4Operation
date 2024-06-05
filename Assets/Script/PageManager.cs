using UnityEngine;
using UnityEngine.UI;

class PageManager : DelegateEvent
{
    public Transform buttonRoot;

    protected int pageIndex;
    protected int operationIndex; //0 add, 1 substraction, 2 multiplication, 3 division

}