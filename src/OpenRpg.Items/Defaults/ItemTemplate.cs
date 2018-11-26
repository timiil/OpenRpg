using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Modifications;
using OpenRpg.Core.Requirements;
using OpenRpg.Items.Templates;

namespace OpenRpg.Items.Defaults
{
    public class ItemTemplate : IItemTemplate, IWithItemQuality
    {
        public int Id { get; set; }
        public int ItemType { get; set;  }
        public int ItemQualityType { get; }
        public int ItemValue { get; set; }
        public string AssetCode { get; set; }
        public string NameLocaleId { get; set; }
        public string DescriptionLocaleId { get; set; }
        public IEnumerable<Requirement> Requirements { get; set; }
        public IEnumerable<Effect> Effects { get; set; }
        public IEnumerable<ModificationAllowance> ModificationAllowances { get; set; }
    }
}