using UnityEngine;

public class ViewInteractable : View
{
       private void OnEnable()
       {
              _currentViewState = 0;
              ConfirmState();

              _clear.interactable = false;
              _getResult.interactable = false;
              
       }

       public void ConfirmState()
       {
              _currentViewState += 1;
              ChangeState();
       }

       private void ChangeState()
       {
              switch (_currentViewState)
              {
                     case ViewStates.none:
                            break;
                     
                     case ViewStates.firstOperand:
                            
                            InputField.color = Color.grey;
                            
                            _getResult.interactable = false;
                            _clear.interactable = false;
                            _confirm.interactable = false;

                            foreach (var var in _numbers)
                                   var.interactable = true;

                            foreach (var var in _operands)
                                   var.interactable = false;
                            
                            break;
                     
                     case ViewStates.mathOp:
                            
                            _confirm.interactable = false;
                            
                            foreach (var var in _numbers)
                                   var.interactable = false;
                            
                            foreach (var var in _operands)
                                   var.interactable = true;

                            break;
                     
                     case ViewStates.secondOperand:
                            
                            _confirm.interactable = false;
                            
                            foreach (var var in _numbers)
                                   var.interactable = true;
                            
                            foreach (var var in _operands)
                                   var.interactable = false;
                            
                            break;
                     
                     case ViewStates.inputDone:
                            
                            _confirm.interactable = false;
                            _clear.interactable = true;
                            _getResult.interactable = false;
                            
                            foreach (var var in _numbers)
                                   var.interactable = false;
                            
                            break;
                     
              }
       }
}