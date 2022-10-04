using UnityEngine;

public class ViewActions : ViewInteractable
{
    public void SetResult()
    {
        properties.Number1 = _firstNumber;
        properties.Number2 = _secondNumber;
        properties.MathOperation = _mathOp;
        
        InputField.text += " = " + properties.Number3.ToString();

        OldInputField.enabled = true;
        OldInputField.text = InputField.text;
    }

    public void EnterNumberToInputField(int number)
    {
        OldInputField.enabled = false;
        InputField.color = Color.black;

        InputField.text += number.ToString();
        
        if (_currentViewState == ViewStates.firstOperand)
        {
            _firsString += number.ToString();
            _firstNumber = int.Parse(_firsString);
            
            _confirm.interactable = true;
        }
        else if (_currentViewState == ViewStates.secondOperand)
        {
            _secondString += number.ToString();
            _secondNumber = int.Parse(_secondString);

            _getResult.interactable = true;
        }
    }
    
    public void SelectMathOpertaion(int mathOp)
    {
        if (_currentViewState == ViewStates.mathOp)
        {
            _mathOp = (ModelMathFunction.mathOP) mathOp;

            char tempOpString;
            
            switch (_mathOp)
            {
                case ModelMathFunction.mathOP.add:
                    tempOpString = '+';
                    break;
                case ModelMathFunction.mathOP.subs:
                    tempOpString = '-';
                    break;
                case ModelMathFunction.mathOP.multi:
                    tempOpString = 'X';
                    break;
                case ModelMathFunction.mathOP.div:
                    tempOpString = '/';
                    break;
                default:
                    tempOpString = ' ';
                    break;
            }

            InputField.text = _firsString + " " + tempOpString + " ";
        }
        
        _confirm.interactable = true;
    }

    public void Clear()
    {
        _currentViewState = 0;

        _firsString = "";
        _firstNumber = 0;

        _secondNumber = 0;
        _secondString = "";

        _mathOp = ModelMathFunction.mathOP.none;

        InputField.text = "";
        OldInputField.enabled = true;
    }
}
