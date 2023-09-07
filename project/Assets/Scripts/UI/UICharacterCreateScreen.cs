using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterCreateScreen : MonoBehaviour
{
    private TMP_InputField _characterNameInput;
    private GameObject _characterSelectPanel;
    private Image _chracterChoiceButtonImage;
    private Button _completeButton;
    private Character _character;

    private void Awake()
    {
        _characterNameInput = GetComponentInChildren<TMP_InputField>();
        _completeButton = transform.Find("ChracterChoiceButton").GetComponent<Button>();
        _chracterChoiceButtonImage = transform.Find("ChracterChoiceButton").GetComponentInChildren<Image>();
        _characterSelectPanel = transform.Find("ChracterSelectPanel").gameObject;
        _character = GameObject.Find("Player").GetComponent<Character>();
    }

    private bool isCorrectNameCondition()
    {
        if (_characterNameInput.text.Length < 2)
            return false;
        return true;
    }

    public void SetCharacterName()
    {
        if (!isCorrectNameCondition())
            return;
        _character.SetName(_characterNameInput.text);
        gameObject.SetActive(false);
    }
    public void PopupCharacterSelectPanel()
    {
        _characterSelectPanel.SetActive(true);
    }
    public void SelectCharacterSprite(Sprite characterSprite)
    {
        _chracterChoiceButtonImage.sprite = characterSprite;
    }
    public void SetCharacterSprite()
    {
        
    }



}
