using System;

namespace JSReader
{
    public abstract class Json
    {
        private JSReader Reader = null;
        public Json() { }
        public Json(string iText) { Read(iText); }
        
        public abstract void Read(string iText);

        public abstract string LazyJson { get; }
        public abstract bool IsValid { get; }
    }
}
