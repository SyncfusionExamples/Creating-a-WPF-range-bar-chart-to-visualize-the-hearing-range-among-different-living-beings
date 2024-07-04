namespace HearingRangeDemo
{
    public class HearingRangeModel
    {
        public string LivingBeings { get; set; }
        public  double HighValue { get; set; }
        public double LowValue { get; set; }

        public HearingRangeModel(string livingBeings, double highValue, double lowValue)
        {
            LivingBeings = livingBeings;
            HighValue = highValue;
            LowValue = lowValue;
        }
    }
}