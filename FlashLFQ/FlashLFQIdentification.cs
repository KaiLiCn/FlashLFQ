﻿namespace FlashLFQ
{
    public class FlashLFQIdentification
    {
        public readonly string BaseSequence;
        public readonly string FullSequence;
        public readonly double ms2RetentionTime;
        public readonly double monoisotopicMass;
        public readonly int initialChargeState;
        public FlashLFQProteinGroup proteinGroup;
        public double massToLookFor;
        public string fileName = "";

        public FlashLFQIdentification(string[] input)
        {
            fileName = input[0];
            BaseSequence = input[1];
            FullSequence = input[2];
            monoisotopicMass = double.Parse(input[3]);
            ms2RetentionTime = double.Parse(input[4]);
            initialChargeState = int.Parse(input[5]);
        }

        override public string ToString()
        {
            return FullSequence;
        }
    }
}