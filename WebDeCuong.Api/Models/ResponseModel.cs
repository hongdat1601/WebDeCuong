﻿namespace WebDeCuong.Api.Models
{
    public class ResponseModel
    {
        public string Status { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public object? Result { get; set; }
    }
}
