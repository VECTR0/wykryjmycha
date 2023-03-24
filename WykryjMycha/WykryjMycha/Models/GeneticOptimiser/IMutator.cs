﻿namespace WykryjMycha.Models.GeneticOptimiser
{
    internal interface IMutator<T> where T : IChromosome
    {
        public T Mutate(T specimen);

        public float Probability { get; init; }
    }
}
