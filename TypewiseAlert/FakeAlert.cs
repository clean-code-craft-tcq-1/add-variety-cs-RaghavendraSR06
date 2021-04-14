namespace TypewiseAlert
{
    public class FakeAlert : IAlerter
    {
        public bool ExecutedAtLeastOnce = false;
        public void Alert(BMSConstants.BreachType breachType)
        {
            ExecutedAtLeastOnce = true;
        }
    }
}
