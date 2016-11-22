namespace JSReader
{
    public abstract class Json
    {
        private JSReader Reader = null;
        public Json() { }

        public abstract string JText { get; }
        public abstract string JTextLight { get; }
        public abstract bool IsValid { get; }
    }
}
