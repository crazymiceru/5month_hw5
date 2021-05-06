namespace hw5
{
    internal sealed class FabricForMage : IFabricParceUnitData
    {
        private static string UnitType = "mag";
        public bool Parce(SplitStringData dataSplitString)
        {            
            int hp;
            int mana;

            if (dataSplitString.unitType == UnitType)
            {
                if (int.TryParse(dataSplitString.data.GetParamFromString("health"),out hp) &&
                    int.TryParse(dataSplitString.data.GetParamFromString("mana"), out mana)
                    )
                {
                    new Mage(hp, mana);
                }

                
            }
            return false;
        }

    }
}
