public static class ModelMathFunction
{
    public static float GetResult(int a, int b, mathOP op)
    {
        switch (op)
        {
            case mathOP.add:
                return a + b;
            case mathOP.subs:
                return a - b;
            case mathOP.multi:
                return a * b;
            case mathOP.div:
                return (float)a / b;
            default:
                return 0;
        }
    }

    public enum mathOP
    {
        add = 1,
        subs = 2,
        multi = 3,
        div = 4,
        none = 5
    }   
}
