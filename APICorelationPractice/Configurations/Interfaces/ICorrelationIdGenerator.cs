﻿namespace APICorelationPractice.Configurations.Interfaces
{
    public interface ICorrelationIdGenerator
    {
        string Get();
        void Set(string correlationId);
    }
}
