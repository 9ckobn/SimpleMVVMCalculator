using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;

public class StateSaveMachine : ViewInteractable
{
    
    
        private Dictionary<string, string> toSerialize;

        private const string statekey = "state";
        private const string firstNumberKey = "first";
        private const string secondNumberKey = "second";
        private const string mathOpKey = "mathOp";
        
        private const string inputKey = "input";

        private string _path;
        
        private void OnDestroy()
        {
            _path = Path.Combine(Application.persistentDataPath, "CalculatorState.json");
            
            toSerialize[statekey] = _currentViewState.ToString();
            toSerialize[firstNumberKey] = _firstNumber.ToString();
            toSerialize[secondNumberKey] = _secondNumber.ToString();
            toSerialize[mathOpKey] = _mathOp.ToString();
            toSerialize[inputKey] = InputField.text;

            string json = JsonConvert.SerializeObject(toSerialize, Formatting.Indented);

            byte[] bytes = Encoding.ASCII.GetBytes(json);

            File.WriteAllBytes(_path, bytes);

        }
}