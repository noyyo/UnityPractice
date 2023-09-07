using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterCreateScreen : MonoBehaviour
{
    private TMP_InputField _characterNameInput;
    private GameObject _characterSelectPanel;
    private Button _characterChoiceButton;
    private Button[] _characterButtons;
    private Button _completeButton;
    private Character _character;

    private void Awake()
    {
        _characterNameInput = GetComponentInChildren<TMP_InputField>();
        _characterChoiceButton = transform.Find("ChracterChoiceButton").GetComponent<Button>();
        _characterSelectPanel = transform.Find("ChracterSelectPanel").gameObject;
        _characterButtons = _characterSelectPanel.GetComponentsInChildren<Button>();
        _completeButton = transform.Find("CompleteButton").GetComponent<Button>();
        _character = GameObject.Find("Player").GetComponent<Character>();
    }
    private void Start()
    {
        SetButtonOnClickListener();
    }
    private bool isCorrectNameCondition()
    {
        if (_characterNameInput.text.Length < 2)
            return false;
        return true;
    }
    private void SetButtonOnClickListener()
    {
        foreach (Button btn in _characterButtons)
        {
            btn.onClick.AddListener(() => SelectCharacterSprite(btn.GetComponent<Image>().sprite));
            btn.onClick.AddListener(CloseCharacterSelectPanel);
        }
        _characterChoiceButton.onClick.AddListener(OpenCharacterSelectPanel);

        _completeButton.onClick.AddListener(SetCharacterName);
        _completeButton.onClick.AddListener(SetCharacterVisual);
    }
    public void SetCharacterName()
    {
        if (!isCorrectNameCondition())
            return;
        _character.SetName(_characterNameInput.text);
        gameObject.SetActive(false);
    }
    public void OpenCharacterSelectPanel()
    {
        _characterSelectPanel.SetActive(true);
    }
    public void CloseCharacterSelectPanel()
    {
        _characterSelectPanel.SetActive(false);
    }
    public void SelectCharacterSprite(Sprite characterSprite)
    {
        _characterChoiceButton.transform.Find("CharacterImage").GetComponent<Image>().sprite = characterSprite;
    }
    public void SetCharacterVisual()
    {
        Image characterImage = _characterChoiceButton.transform.Find("CharacterImage").GetComponent<Image>();
        _character.SetSprite(characterImage.sprite);
        string characterName = characterImage.sprite.name;
        characterName = characterName.Substring(0, characterName.IndexOf(' '));
        AnimatorController chracterAnimController = Resources.Load<AnimatorController>($"Animation/{characterName}AnimController");
        _character.SetAnimatorController(chracterAnimController);
    }



}
