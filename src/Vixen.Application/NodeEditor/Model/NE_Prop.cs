using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixenApplication.NodeEditor.Model
{
    class NE_Prop
    {
		public Guid Prop_guid { get; } // This should align with the GUID used throughout Vixen to identify things
        public string Name { get; set; }
		public string Description{ get; set; }
        //public int InputCount { get; set; }
        public int OutputCount { get; set; }
		// Should this have a list of LED_Strings with count, color type, color order, etc?
		public NE_Prop(Guid guid, string name)
		{
			Prop_guid = guid;
			Name = name;
		}
	}
}
