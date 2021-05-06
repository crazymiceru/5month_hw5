namespace hw5
{
    internal sealed class FabricForInfantry : IFabricParceUnitData
    {
        private static string UnitType = "infantry";
        public bool Parce(SplitStringData dataSplitString)
        {
            int hp;            

            if (dataSplitString.unitType == UnitType)
            {
                if (int.TryParse(dataSplitString.data.GetParamFromString("health"), out hp))
                {
                    new Infantry(hp);
                }


            }
            return false;
        }
    }
}
