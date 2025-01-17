﻿namespace GrupoWebBackend.Extensions;

public class BaseResponse<T>
{
    public bool Success { get; private set; }
    public string Message { get; private set; }

    public T Resource { get; private set; }
    protected BaseResponse(string message)
    {
        Success = false;
        Message = message;
    }
    protected BaseResponse(T resource)
    {
        Success = true;
        Resource = resource;
    }

    
    
}