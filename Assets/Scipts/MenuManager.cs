using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string UserName 
    { 
        get
        {
            if (_userName == null)
                return "NULL";
            return _userName;
        }
        private set
        {
            _userName = value;
        }
    }
    private string _userName;

    public MenuManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("MenuManager not created");

            return _instance;
        }
    }
    private MenuManager _instance;

    public TMP_InputField userNameField;


    private void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        UserName = userNameField.text;
    }
}
