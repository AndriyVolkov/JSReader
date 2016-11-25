namespace JSReader
{
    public class JProperty : Json
    {
        public JProperty(string _key, Json _value) : base() { Key = _key; Value = _value; }

        public string Key { get; internal set; }
        public Json Value { get; internal set; }
        
        public override string LazyJson { get { return $"{Key}:{(Value == null ? "NULL" : Value.LazyJson)}"; } }

        public override bool IsValid { get { return !string.IsNullOrEmpty(Key) && Value != null && Value.IsValid; } }

        public override void Read(string iText)
        {
            //add code here...
        }

        public override bool Equals(object obj) { return obj != null && obj.GetType() == GetType() && Key.Equals(((JProperty)obj).Key) && Value.Equals(((JProperty)obj).Value); }

        public override int GetHashCode() { return ToString().GetHashCode(); }
        public override string ToString() { return $"\"{Key}\":{(Value == null ? "\"NULL\"" : Value.ToString())}"; }
    }
}
