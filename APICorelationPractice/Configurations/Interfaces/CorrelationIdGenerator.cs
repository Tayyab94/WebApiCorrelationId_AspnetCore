﻿namespace APICorelationPractice.Configurations.Interfaces
{
    public class CorrelationIdGenerator : ICorrelationIdGenerator
    {
        private string _correlationId=  Guid.NewGuid().ToString(); 

        public string Get() => _correlationId;
        public void Set(string correlationId) => correlationId = _correlationId;
    }
}
