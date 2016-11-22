namespace JSReader
{
    public class JProperty : Json
    {
        public JProperty(string _key, Json _value) : base() { Key = _key; Value = _value; }

        public string Key { get; internal set; }
        public Json Value { get; internal set; }
        
        public override string JText { get { return $"\"{Key}\":\"{Value.JText}\""; } }

        public override string JTextLight { get { return $"{Key}:{Value.JText}"; } }

        public override bool IsValid { get { return !string.IsNullOrEmpty(Key) && Value != null && Value.IsValid; } }

        public override bool Equals(object obj) { return obj != null && obj.GetType() == GetType() && Key.Equals(((JProperty)obj).Key) && Value.Equals(((JProperty)obj).Value); }

        public override int GetHashCode() { return ToString().GetHashCode(); }
        public override string ToString() { return $"{Key}:{Value.JTextLight}"; }
    }
}
