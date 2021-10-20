using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCursor : MonoBehaviour
{
    public Texture2D cursor;
    public Texture2D cursorClicked;

    private void Awake()
    {
        ChangueCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void ChangueCursor(Texture2D cursorType)
    {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

    void Start()
    {
        
    }

}
