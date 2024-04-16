namespace DecisionTableCondenser
{
    public class TrueFalseValue
    {
        public TrueFalseValue(bool? value, int column, int row, bool isCondition) 
        {
            this.Value = value; 
            this.Column = column;
            this.Row = row; 
            this.IsCondition = isCondition;
        }

        public bool? Value { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public bool IsCondition { get; set; }
    }
}
