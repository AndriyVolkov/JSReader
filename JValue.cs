using System;

namespace JSReader
{
    public class JValue : JArrayItem
    {
        public JValue(string _value) { Value = _value; }

        public override string JText { get { return $"\"{Value}\""; } }

        public override string JTextLight { get { return $"{Value}"; } }

        public override bool IsValid { get { return true; } }

        public string Value { get; internal set; }
    }
}
