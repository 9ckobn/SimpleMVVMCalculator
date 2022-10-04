using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public List<Button> _numbers;
    public List<Button> _operands;
    public Button _confirm;
    public Button _getResult;
    public Button _clear;
    
    [Space(10)] [SerializeField] protected Text InputField;
    [SerializeField] protected Text OldInputField;

    protected Properties properties = new Properties();

    private protected int _firstNumber;
    [HideInInspector] public string _firsString;
    
    private protected int _secondNumber;
    [HideInInspector] public string _secondString;
    
    protected ModelMathFunction.mathOP _mathOp;

    protected ViewStates _currentViewState;

    private void OnEnable()
    {
        StateSaveMachine saveMachine = new StateSaveMachine();
    }
}