namespace TypewiseAlert
{
    public struct Battery
    {
        public BMSConstants.CoolingType CoolingType;
        public string Brand;
        public Battery(BMSConstants.CoolingType coolingType, string brand)
        {
            this.CoolingType = coolingType;
            this.Brand = brand;
        }
    }

}
