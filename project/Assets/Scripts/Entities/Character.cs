using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    private TextMeshProUGUI _namePlate;

    private void Awake()
    {
        _namePlate = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void SetName(string name)
    {
        Name = name;
        _namePlate.text = name;
        _namePlate.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, name.Length * 30);
    }
}
