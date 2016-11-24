using System;
using System.Collections.Generic;
using System.Linq;

namespace JSReader
{
    public class JArray : JArrayItem
    {
        public JArray(List<JArrayItem> _array) { if(_array!=null) { _Items = _array.Where(x => x != null && x.IsValid).ToList(); } }

        public List<JArrayItem> Items { get { if (_Items == null) { _Items = new List<JArrayItem>(); } return _Items; } } private List<JArrayItem> _Items = null;

        public override string LazyJson { get { return $"[{((Items == null || !Items.Any(x => x != null)) ? "" : (Items.Where(x => x != null).Select(x => x.LazyJson).Aggregate((a, b) => a + "," + b)))}]"; } }
        
        public override bool IsValid { get { return !Items.Any(x=> x == null || !x.IsValid); } }
        
        public override void Read(string iText)
        {
            //add code here...
        }
        public override string ToString() { return $"[{((Items == null || !Items.Any(x => x != null)) ? "" : (Items.Where(x => x != null).Select(x => x.ToString()).Aggregate((a, b) => a + "," + b)))}]"; }
    }
}
