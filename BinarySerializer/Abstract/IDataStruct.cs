﻿namespace BinarySerializer
{
    public interface IDataStruct
    {
        void Serialize(IBinarySerializer serializer);
    }
}