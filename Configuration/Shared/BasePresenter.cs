﻿using jhedgostBK.Model.Dtos.Response;

namespace jhedgostBK.Configuration.Shared;

public class BasePresenter<T> : IBasePresenter<T>
{
    public virtual ResponseDto<T>? GetResponse { get; set; }

    public void Success(T data, string message = "Data retrieved successfully")
    {
        GetResponse = new ResponseDto<T>
        {
            Success = true,
            Message = message,
            Data = data
        };
    }

    public void NotFound(string message = "Data not found")
    {
        GetResponse = new ResponseDto<T>
        {
            Success = false,
            Message = message,
            Data = default
        };
    }

    public void Error(string message)
    {
        GetResponse = new ResponseDto<T>
        {
            Success = false,
            Message = message,
            Data = default
        };
    }
}