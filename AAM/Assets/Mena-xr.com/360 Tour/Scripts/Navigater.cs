using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigater : MonoBehaviour
{
    public int index = 0;

    void OnMouseUp()
    {
        index = (index + 1) % ViewerManager.Instance.views.Count; // Avança para o próximo índice circularmente
        ViewerManager.Instance.LoadNextView(index);
    }

    void OnMouseEnter()
    {
        CursorManager.Instance.SetCursor(CursorType.Hover);
    }

    void OnMouseExit()
    {
        CursorManager.Instance.SetCursor(CursorType.Normal);
    }
}
