using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
	public class ConductingEquipment : Equipment
	{
        private List<long> terminals = new List<long>();

        public List<long> Terminals { get => terminals; set => terminals = value; }

        public ConductingEquipment(long globalId) : base(globalId) 
		{
		}

		public override bool Equals(object obj)
		{
            if (base.Equals(obj))
            {
                ConductingEquipment x = (ConductingEquipment)obj;
                return CompareHelper.CompareLists(x.terminals, this.terminals);
            }
            else
            {
                return false;
            }
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		#region IAccess implementation

		public override bool HasProperty(ModelCode property)
		{
            switch (property)
            {
                case ModelCode.CONDEQ_TERMINALS:
                    return true;

                default:
                    return base.HasProperty(property);

            }
        }

		public override void GetProperty(Property prop)
		{
            switch (prop.Id)
            {
                case ModelCode.CONDEQ_TERMINALS:
                    prop.SetValue(terminals);
                    break;

                default:
                    base.GetProperty(prop);
                    break;
            }
		}

		public override void SetProperty(Property property)
		{
			base.SetProperty(property);
		}

        #endregion IAccess implementation

        #region IReference implementation

        public override bool IsReferenced
        {
            get
            {
                return terminals.Count != 0 || base.IsReferenced;
            }
        }

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
		{
            if (terminals != null && terminals.Count != 0 && (refType == TypeOfReference.Target || refType == TypeOfReference.Both))
            {
                references[ModelCode.CONDEQ_TERMINALS] = terminals.GetRange(0, terminals.Count);
            }

            base.GetReferences(references, refType);
		}

		#endregion IReference implementation
	}
}
