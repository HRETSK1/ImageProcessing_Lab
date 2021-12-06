namespace WindowsFormsApp3
{
    public class GenericFilter : ConvolutionFilterBase
    {
        private string filterName = "Generic Filter";
        public override string FilterName
        {
            get => filterName;
            set => filterName = value;
        }

        private readonly double factor = 1.0;
        public override double Factor => factor;

        private readonly double bias = 0.0;
        public override double Bias => bias;

        private double[,] filterMatrix = new double[,] { { 0.0, 0.0, 0.0 },
                                                         { 0.0, 0.0, 0.0 },
                                                         { 0.0, 0.0, 0.0 }};

        public override double[,] FilterMatrix
        {
            get => filterMatrix;
            set => filterMatrix = value;
        }
    }
}
