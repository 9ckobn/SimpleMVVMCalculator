using System.ComponentModel;

public class Properties : INotifyPropertyChanged
{

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;    
    private int _number1;
    public int Number1 { get => _number1;
        set { _number1 = value;
            OnPropertyChanged("Number3");
        }
    }

    private int _number2;
    public int Number2 { get => _number2;
        set { _number2 = value; OnPropertyChanged("Number3"); } }

    private ModelMathFunction.mathOP _mathOp;
    
    public ModelMathFunction.mathOP MathOperation { get => _mathOp;
        set { _mathOp = value; OnPropertyChanged("Number3"); } }

    public float Number3 => ModelMathFunction.GetResult(Number1, Number2, MathOperation);
}
