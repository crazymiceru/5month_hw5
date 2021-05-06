using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace hw5
{
    internal sealed class FabricsParseUnitData
    {
        private ILoad _load;
        private List<IFabricParceUnitData> _fabrics;
        private List<SplitStringData> _inputStrings;

        internal FabricsParseUnitData(ILoad load)
        {
            _load = load;
            _fabrics = new List<IFabricParceUnitData>();
        }

        internal void AddFabric(IFabricParceUnitData fabricParceUnitData)
        {
            _fabrics.Add(fabricParceUnitData);
        }

        internal void Parse(string path)
        {
            var stringData = _load.Load(path);
            _inputStrings = DecompositeString(stringData);

            for (int k = 0; k < _inputStrings.Count; k++)
            {
                for (int i = 0; i < _fabrics.Count; i++)
                {
                    if (_fabrics[i].Parce(_inputStrings[k])) break;
                }
            }
        }

        private List<SplitStringData> DecompositeString(string stringData)
        {
            List<SplitStringData> outputStrings = new List<SplitStringData>();

            string pattern = "unit.+?:.+?{(.+?type.+?:.+?\"(.+?)\".+?)}";

            foreach (Match item in Regex.Matches(stringData, pattern, RegexOptions.IgnoreCase))
            {
                outputStrings.Add(new SplitStringData { data = item.Groups[1].Value, unitType = item.Groups[2].Value });

            }

            return outputStrings;
        }
    }
}
