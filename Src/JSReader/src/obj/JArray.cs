using System.Collections.Generic;
using System.Linq;

namespace JSReader
{
    public class JArray : JArrayItem
    {
        public JArray(List<JArrayItem> _array) { if(_array!=null) { _Items = _array.Where(x => x != null && x.IsValid).ToList(); } }

        public List<JArrayItem> Items { get { if (_Items == null) { _Items = new List<JArrayItem>(); } return _Items; } }
        public List<JArrayItem> _Items = null;

        public override string JText { get { return $"[{((Items == null || !Items.Any()) ? "" : (Items.Select(x => x.JText).Aggregate((a, b) => a + "," + b)))}]"; } }

        public override string JTextLight { get { return $"[{((Items == null || !Items.Any()) ? "" : (Items.Select(x => x.JTextLight).Aggregate((a, b) => a + "," + b)))}]"; } }
        
        public override bool IsValid { get { return !Items.Any(x=> x == null || !x.IsValid); } }
    }
}
