using System.Collections;
using System.Collections.Generic;
using Controller;
using Model;
using Model.Config;
using UnityEngine;
using Utilities;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private Settings _settings;
    [SerializeField] private Canvas _targetCanvas;
    private float _timeScale = 1;  //Change game speed from 1 to 5;
    
    //One line comment
    /*
     *    Multiply comment
    */
    
    void Start()
    {
        Time.timeScale = _timeScale;
        _settings.LoadPrefabs();
        ServiceLocator.Register(_settings);
        
        var rootController = new RootController(_settings, _targetCanvas);
        ServiceLocator.Register(rootController);
    }
}
