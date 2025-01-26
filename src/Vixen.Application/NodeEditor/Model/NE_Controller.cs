using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixenApplication.NodeEditor.Model
{
    class NE_Controller
    {
        public Guid Controller_guid { get; } // This should align with the GUID used throughout Vixen to identify things
		public string Name { get; set; }
        public string Description { get; set; }
        public int OutputCount { get; set; }
        // Should this become a list of Outputs, where Outputs are modelled with counts, protocol, type, etc?

        public NE_Controller(Guid guid, string name) {
			Controller_guid = guid;
            Name = name;
        }
    }
}
