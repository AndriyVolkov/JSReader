using System;
using System.Collections.Generic;
using System.Linq;

namespace JSReader
{
    public class JObject : JArrayItem
    {
        public List<JProperty> Properties { get { if (Properties_ == null) { Properties_ = new List<JProperty>(); } return Properties_; } }
        private List<JProperty> Properties_=null;
        public JObject(List<JProperty> _Properties = null) { Properties_ = _Properties; }

        public override string JText { get { return $"{{{((Properties==null||!Properties.Any())?"":(Properties.Select(x=>x.JText).Aggregate((a,b)=>a+","+b)))}}}"; } }

        public override string JTextLight { get { return $"{{{((Properties == null || !Properties.Any()) ? "" : (Properties.Select(x => x.JTextLight).Aggregate((a, b) => a + "," + b)))}}}"; } }

        public override bool IsValid { get { return !Properties.Any(x => x==null || !x.IsValid); } }

        public bool Save(JProperty property, bool reset = true)
        {
            try {
                if (property != null && property.IsValid)
                {
                    if (Properties.Any(x => x.Key.Equals(property.Key))) { }
                }
            } catch { }
            return false;
        }
        internal void Clear() { Properties_ = null; }
    }
}
