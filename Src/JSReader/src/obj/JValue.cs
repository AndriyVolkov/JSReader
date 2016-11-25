using System;

namespace JSReader
{
    public class JValue : JArrayItem
    {
        public JValue(string _value) { Value = _value; }

        public override string LazyJson { get { return $"{Value}"; } }

        public override bool IsValid { get { return true; } }

        public string Value { get; internal set; }

        public override string ToString() { return $"\"{Value}\""; }

        public override void Read(string iText)
        {
            Value = iText;
        }
    }
}
