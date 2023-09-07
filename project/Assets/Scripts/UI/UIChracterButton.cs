using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIChracterButton : MonoBehaviour
{
    private Button _characterButton;

    private void Awake()
    {
        _characterButton = GetComponent<Button>();
    }

    private void OnButtonClick()
    {

    }
}
